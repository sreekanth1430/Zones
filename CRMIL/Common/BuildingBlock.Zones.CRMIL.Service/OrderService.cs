using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using BuildingBlock.Core.Logger;
using BuildingBlock.Core.Model;
using BuildingBlock.Zones.Model.CRMIL;
using BuildingBlock.Zones.Model.CRMIL.OrderRecall.ResponseModel;
using BuildingBlock.Zones.CRMIL.Application.ApplicationBusiness.OrderRecall.Queries;
using BuildingBlock.Zones.CRMIL.Repo;
using MediatR;
using Microsoft.Extensions.Configuration;
using BuildingBlock.Zones.Model.OrderModel;
using Newtonsoft.Json;
using order1 = BuildingBlock.Zones.Model.OrderModel;
using CRMIL.DA.Interfaces.AX.SalesOrder;
using salesOrderRef = CRMIL.DA.Interfaces.AX.SalesOrder;
using BuildingBlock.Zones.CRMIL.Model.Order;
using Microsoft.Data.SqlClient;
using System.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using customNotes = BuildingBlock.Zones.Model.OrderModel;
using System.Xml;
using BuildingBlock.Zones.Model.CRMIL.OrderRecall.RequestModel;
using BuildingBlock.Zones.CRMIL.Model.Order.OrderRecall.RequestModel;

namespace BuildingBlock.Zones.CRMIL.Api.Service
{
    /// <summary>
    /// Service
    /// </summary>
    public class OrderService : IOrderService
    {
		private readonly IWebHostEnvironment _webHostEnvironment;
		private IOrderRepository _orderRepo;
        private readonly IMediator _mediator;
        private readonly IConfiguration _configuration;
        public OrderService (IWebHostEnvironment webHostEnvironment,IOrderRepository orderRepo, ICoreLogger<OrderService> coreLogger, IMediator mediator, IConfiguration config)
        {
			_webHostEnvironment = webHostEnvironment;
			_orderRepo = orderRepo;
            _mediator = mediator;
            _configuration = config;
        }
        /// <summary>
        /// Create Order Async
        /// </summary>
        /// <param name="p_Order"></param>
        /// <returns></returns>
        public async Task<bool> CreateOrderAsync(order1.Order p_Order)
        {
            try
            {
				AxdEntity_SalesTable[] oAxSalesTable = p_Order.AXSalesTable;
                AxdSalesOrder oSalesOrder = new()
                {
                    SalesTable = oAxSalesTable
                };
                AxdEntity_ZonSalesLineExtension oArroneSalesLineExt = new();
				if (p_Order.AXSalesTable[0].SalesLine.Length > 0 && p_Order.AXSalesTable[0].SalesLine[0].ZonSalesLineExtension.Length > 0)
					oArroneSalesLineExt = p_Order.AXSalesTable[0].SalesLine[0].ZonSalesLineExtension[0];

				if (p_Order.AXSalesTable[0].SalesLine[0].ZonSalesLineExtension.Length > 0)
				{
					oArroneSalesLineExt.NeedByDate = p_Order.AXSalesTable[0].SalesLine[0].ZonSalesLineExtension[0].NeedByDate;
					oArroneSalesLineExt.Qualifier = p_Order.AXSalesTable[0].SalesLine[0].ZonSalesLineExtension[0].Qualifier;
					oArroneSalesLineExt.IsFinishedGood = p_Order.AXSalesTable[0].SalesLine[0].ZonSalesLineExtension[0].IsFinishedGood;
					oArroneSalesLineExt.IsTSCService = p_Order.AXSalesTable[0].SalesLine[0].ZonSalesLineExtension[0].IsTSCService;
					oArroneSalesLineExt.PalletQty = p_Order.AXSalesTable[0].SalesLine[0].ZonSalesLineExtension[0].PalletQty;
					oArroneSalesLineExt.PalletRate = p_Order.AXSalesTable[0].SalesLine[0].ZonSalesLineExtension[0].PalletRate;
					oArroneSalesLineExt.PalletShipOutDate = p_Order.AXSalesTable[0].SalesLine[0].ZonSalesLineExtension[0].PalletShipOutDate;
				}
				if (p_Order.AXSalesTable[0].SalesLine[0].ZonSalesLineExtension.Length > 0 && p_Order.AXSalesTable[0].SalesLine[0].ZonSalesLineExtension[0].CustomerContractId != null)
				{
					oArroneSalesLineExt.CustomerContractId = p_Order.AXSalesTable[0].SalesLine[0].ZonSalesLineExtension[0].CustomerContractId;
					oArroneSalesLineExt.PricingLimitation = p_Order.AXSalesTable[0].SalesLine[0].ZonSalesLineExtension[0].PricingLimitation;
					oArroneSalesLineExt.PricingLimitationSpecified = p_Order.AXSalesTable[0].SalesLine[0].ZonSalesLineExtension[0].PricingLimitationSpecified;
					oArroneSalesLineExt.ContractSalesPrice = p_Order.AXSalesTable[0].SalesLine[0].ZonSalesLineExtension[0].ContractSalesPrice;
					oArroneSalesLineExt.ContractSalesPriceSpecified = p_Order.AXSalesTable[0].SalesLine[0].ZonSalesLineExtension[0].ContractSalesPriceSpecified;
					oArroneSalesLineExt.WYLineRefId = p_Order.AXSalesTable[0].SalesLine[0].ZonSalesLineExtension[0].WYLineRefId;
				}
				oSalesOrder.SalesTable[0].SalesLine[0].ZonSalesLineExtension[0] = oArroneSalesLineExt;

				try
				{
					/*** Add customization notes ***/
					if (oSalesOrder.SalesTable != null && p_Order.LineCustomizationNoteInput != null)
					{
						for (int i = 0; i < p_Order.LineCustomizationNoteInput.Length; i++)
						{
							int iLineNumber = Int32.Parse(p_Order.LineCustomizationNoteInput[i].LineNumber);
							for (int y = 0; y < oSalesOrder.SalesTable.Length; y++)
							{
								//iLineNumber
								if (oSalesOrder.SalesTable[y].SalesLine != null)
								{
									for (int z = 0; z < oSalesOrder.SalesTable[y].SalesLine.Length; z++)
									{
										if (iLineNumber == (int)oSalesOrder.SalesTable[y].SalesLine[z].LineNum && oSalesOrder.SalesTable[y].SalesLine[z].ZonSalesLineInfo == null)
										{
											oSalesOrder.SalesTable[y].SalesLine[z].ZonSalesLineInfo = new AxdEntity_ZonSalesLineInfo[1];
											oSalesOrder.SalesTable[y].SalesLine[z].ZonSalesLineInfo[0] = new AxdEntity_ZonSalesLineInfo();
											for (int u = 0; u < p_Order.LineCustomizationNoteInput[i].CustomizationNoteInput.Length; u++)
											{
												string sPropertyName = p_Order.LineCustomizationNoteInput[i].CustomizationNoteInput[u].ID;
												if (sPropertyName != null)
												{
													System.Reflection.PropertyInfo refProperty = typeof(AxdEntity_ZonSalesLineInfo).GetProperty(sPropertyName);
													try
													{
														string sDataType = getNoteFieldDataType(sPropertyName);
														if (sDataType != null)
														{
															if (sDataType.ToLower().Equals("axyesno"))
															{
																System.Reflection.PropertyInfo refSpecified = typeof(AxdEntity_ZonSalesLineInfo).GetProperty(sPropertyName + "Specified");
																refSpecified.SetValue(oSalesOrder.SalesTable[y].SalesLine[z].ZonSalesLineInfo[0], true, null);
																if (p_Order.LineCustomizationNoteInput[i].CustomizationNoteInput[u].Value.Trim() != null)
																{
																	if (p_Order.LineCustomizationNoteInput[i].CustomizationNoteInput[u].Value.Trim().ToLower().Equals("true"))
																	{
																		refProperty.SetValue(oSalesOrder.SalesTable[y].SalesLine[z].ZonSalesLineInfo[0], salesOrderRef.AxdEnum_NoYes.Yes, null);
																	}
																	else
																	{
																		refProperty.SetValue(oSalesOrder.SalesTable[y].SalesLine[z].ZonSalesLineInfo[0], salesOrderRef.AxdEnum_NoYes.No, null);
																	}
																}
															}
															else
															{
																if (sDataType.ToLower().Equals("datetime"))
																{
																	System.Reflection.PropertyInfo refSpecified = typeof(AxdEntity_ZonSalesLineInfo).GetProperty(sPropertyName + "Specified");
																	refSpecified.SetValue(oSalesOrder.SalesTable[y].SalesLine[z].ZonSalesLineInfo[0], true, null);
																	string[] formats = { "MM/dd/yyyy" };
																	DateTime dtDate = DateTime.ParseExact(p_Order.LineCustomizationNoteInput[i].CustomizationNoteInput[u].Value.Trim(), formats, new System.Globalization.CultureInfo("en-US"), System.Globalization.DateTimeStyles.None);
																	refProperty.SetValue(oSalesOrder.SalesTable[y].SalesLine[z].ZonSalesLineInfo[0], dtDate, null);
																}
																else
																{
																	refProperty.SetValue(oSalesOrder.SalesTable[y].SalesLine[z].ZonSalesLineInfo[0], p_Order.LineCustomizationNoteInput[i].CustomizationNoteInput[u].Value.Trim(), null);
																}
															}
														}
													}
													catch (Exception)
													{
													}
												}
											}
										}
									}
								}
							}
						}
					}
					var res = _orderRepo.CreateOrder();

					// check if the order has PO attachment
					// TODO: If the storage process fails.. update the user that order was created but PO could not be uploaded
					if (p_Order.POAttachmentFlag != null && p_Order.POAttachmentFlag.ToLower().Equals("available") && p_Order.POFileName != null && p_Order.POFolderName != null)
					{
						try
						{
							p_Order = _orderRepo.AddOrderAttachmentPOMultiple( p_Order).Result;
						}
						catch (Exception axFail)

						{
							throw axFail;
						}
					}

					if (p_Order.OrderDocument != null)
					{
						for (int i = 0; i < p_Order.OrderDocument.Length; i++)
						{
							if (p_Order.OrderDocument[i] != null)
							{
								p_Order.OrderDocument[i].SalesID = p_Order.SalesID;
							}
						}
						try
						{
							var result= _orderRepo.SaveRecallOtherDocs(p_Order.OrderDocument);
						}
						catch (Exception ex)
						{
							throw ex;// swallow exception. need to discuss what-if-only-docs-fail scenario
						}
					}

					//Add code To add OrderFreightAnalysis in SID database 
					if (p_Order.OrderFreightAnalysiss != null)
					{
						try
						{
							SqlConnection oConnection = null; ;
							SqlCommand oCommand = null;
							try
							{
								oConnection = new SqlConnection(_configuration["SIDConnectionString"]);
								oConnection.Open();
								for (int k = 0; k < p_Order.OrderFreightAnalysiss.Length; k++)
								{
									string sOrderID = p_Order.SalesID;
									string sOrderID10 = p_Order.SalesID + (k + 1).ToString("D2");
									string sOrderID12 = sOrderID10 + "00";
									oCommand = null;

									string sQuery = "INSERT INTO OrderFreightAnalysis (orderNum8,orderNum10,orderNum12,deliveryMode,deliveryModeName,overrideCode,shippingAmt,suggestedAmt,shippingCost,levelWeight,custFreightAcct,overrideCodeDesc,createdDate, ResidentialCharge, OutOfAreaCharge) VALUES (@OrderNum8, @OrderNum10, @OrderNum12, @DeliveryMode, @DeliveryModeName, @OverrideCode, @ShippingAmt, @SuggestedAmt, @ShippingCost, @LevelWeight, @CustFreightAcct, @OverrideCodeDesc, getdate(), @ResidentialCharge, @OutOfAreaCharge)";
									oCommand = new SqlCommand(sQuery, oConnection);
									oCommand.CommandType = CommandType.Text;
									oCommand.Parameters.AddWithValue("@OrderNum8", p_Order.SalesID);
									oCommand.Parameters.AddWithValue("@OrderNum10", sOrderID10);
									oCommand.Parameters.AddWithValue("@OrderNum12", sOrderID12);
									oCommand.Parameters.AddWithValue("@DeliveryMode", p_Order.OrderFreightAnalysiss[k].DeliveryMode);
									oCommand.Parameters.AddWithValue("@DeliveryModeName", p_Order.OrderFreightAnalysiss[k].DeliveryModeName);

									if (string.IsNullOrEmpty(p_Order.OrderFreightAnalysiss[k].OverrideCode))
										oCommand.Parameters.AddWithValue("@OverrideCode", DBNull.Value);
									else
										oCommand.Parameters.AddWithValue("@OverrideCode", p_Order.OrderFreightAnalysiss[k].OverrideCode);

									if (string.IsNullOrEmpty(p_Order.OrderFreightAnalysiss[k].OverrideCodeDesc))
										oCommand.Parameters.AddWithValue("@OverrideCodeDesc", DBNull.Value);
									else
										oCommand.Parameters.AddWithValue("@OverrideCodeDesc", p_Order.OrderFreightAnalysiss[k].OverrideCodeDesc);

									if (string.IsNullOrEmpty(p_Order.OrderFreightAnalysiss[k].CustFreightAcct))
										oCommand.Parameters.AddWithValue("@CustFreightAcct", DBNull.Value);
									else
										oCommand.Parameters.AddWithValue("@CustFreightAcct", p_Order.OrderFreightAnalysiss[k].CustFreightAcct);

									oCommand.Parameters.AddWithValue("@ShippingAmt", p_Order.OrderFreightAnalysiss[k].ShippingAmt);
									oCommand.Parameters.AddWithValue("@SuggestedAmt", p_Order.OrderFreightAnalysiss[k].SuggestedAmt);
									oCommand.Parameters.AddWithValue("@ShippingCost", p_Order.OrderFreightAnalysiss[k].ShippingCost);
									oCommand.Parameters.AddWithValue("@LevelWeight", p_Order.OrderFreightAnalysiss[k].LevelWeight);
									//Save residentail and out of area charges
									oCommand.Parameters.AddWithValue("@ResidentialCharge", p_Order.OrderFreightAnalysiss[k].ResidentialChargeProposed);
									oCommand.Parameters.AddWithValue("@OutOfAreaCharge", p_Order.OrderFreightAnalysiss[k].OutOfAreaChargeProposed);

									oCommand.ExecuteNonQuery();
								}
							}
							finally
							{
								if (oConnection != null)
								{
									oConnection.Close();
									oConnection = null;
								}
							}
						}
						catch (Exception ex)
						{
							throw ex;
						}
					}
				}
				catch (Exception ex)
				{
					throw ex;
				}
				return true;

            }catch(Exception ex)
            {
                throw ex;
            }
        }
        private string getNoteFieldDataType(string p_PropertyName)
        {
            string sDataType = null;
            string configCustomNotesPath = null;
			string webRootPath = _webHostEnvironment.WebRootPath;
			string contentRootPath = _webHostEnvironment.ContentRootPath;

			string path = "~/Resources/CustomizationNoteConfiguration.xml";
			path = Path.Combine(webRootPath, "CSS");
			List<customNotes.CustomizationNote> lstXMLConfigField = LoadCustomizationField(configCustomNotesPath);

			for (int h = 0; h < lstXMLConfigField.Count; h++)
			{
				customNotes.CustomizationNote f = lstXMLConfigField[h];
				if (f.FieldName.ToLower().Equals(p_PropertyName.ToLower()))
					sDataType = f.FieldDataType;
			}
            // Bug 15455: Customization notes not saving on large orders
            // Resolution: In very few cases System.Web.HttpContext.Current object is setting null when update is called from CRM. 
            // Not able to find the actual cause so fixing the issue by putting null check.This is a workaround not a proper fix.
            //if (HttpContext.Current != null && System.Web.HttpContext.Current.Server != null)
            //{
            //    var es = HttpContext.Current.Server.MapPath();
            //    configCustomNotesPath = System.Web.HttpContext.Current.Server.MapPath(_configuration["customnotes_config_xml"]);
            //}
            //else
                sDataType = GetDataTypeForProperty(p_PropertyName);

            return sDataType;
        }
		private List<customNotes.CustomizationNote> LoadCustomizationField(string p_XMLPath)
		{
			List<customNotes.CustomizationNote> list = new List<customNotes.CustomizationNote>();
			XmlReader reader = XmlReader.Create(p_XMLPath);  
			customNotes.CustomizationNote field = null;
			while (reader.Read())
			{
				if (reader.NodeType == System.Xml.XmlNodeType.Element && reader.Name.ToLower().Equals("field"))
				{
					field = new customNotes.CustomizationNote();
					field.FieldName = reader.GetAttribute("name");
					field.FieldType = reader.GetAttribute("type");
					field.FieldDataType = reader.GetAttribute("datatype");
					if (reader.GetAttribute("maxLength") == null)
						field.FieldMaxLength = -1;
					else
						field.FieldMaxLength = Convert.ToInt32(reader.GetAttribute("maxLength"));
					list.Add(field);
				}
			}
			return list;
		}
		private static string GetDataTypeForProperty(string propertyName)
		{
			string dataType = "string";
			switch (propertyName.ToUpper())
			{
				case "EXPIRATIONDATE":
					dataType = "datetime";
					break;
				case "INSIDEDELIVERY":
					dataType = "axyesno";
					break;
				case "LIFTGATEREQUIRED":
					dataType = "axyesno";
					break;
				case "LOADINGDOCK":
					dataType = "axyesno";
					break;
				case "STARTDATE":
					dataType = "datetime";
					break;
				default:
					dataType = "string";
					break;
			}
			return dataType;
		}
        /// <summary>
        /// SingleAsync
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<OrderDetailsDTO> IOrderService.GetOrderById(string id)
        {
            GetOrderQuery getOrderQuery = new GetOrderQuery { OrderAccount = id.ToString() };
           
            var orderDetailsDto=_mediator.Send(getOrderQuery);
            return orderDetailsDto;
           // return _orderRepo.SingleAsync(id);
        }



        /// <summary>
        /// Recall Order Async
        /// </summary>
        /// <param name="orderDetailsRequest"></param>
        /// <returns></returns>
        Task<List<OrderResponseData>> IOrderService.RecallOrderAsync(OrderDetailsRequest orderDetailsRequest)
        {
            var orderResponse = new List<OrderResponseData>();
            if (!string.IsNullOrEmpty(orderDetailsRequest.SalesID) && !string.IsNullOrEmpty(orderDetailsRequest.CallContextCompany))
            {
                OrderRecallQuery orderDetailsQuery = new OrderRecallQuery { _salesOrderList = new string[] { orderDetailsRequest.SalesID }, _companyId = orderDetailsRequest.CallContextCompany };
                orderResponse = _orderRepo.GetOrderRecall(orderDetailsQuery).Result;
                return Task.Run(() => orderResponse);
            }
            else
            {
                return Task.Run(() => orderResponse);
            } 
        }

        

        public string getrcyclefee()
        {
            RecycleFee codes = new RecycleFee();

            codes.RecycleFeeDescription = "null";
            codes.CorrelationId = "null"; 
            codes.SKU = "null";
            codes.OriginalEDPNumber = "null";
            codes.RecycleFeeName = "null";
            codes.RecycleFeeDescription = "null";
            codes.RecycleFeeCode = "null";
            var result = JsonConvert.SerializeObject(codes);

            return result;
        }
    }
}
