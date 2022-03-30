using BuildingBlock.Core.Repo;
using BuildingBlock.Zones.Model.CRMIL;
using BuildingBlock.Zones.Model.CRMIL.OrderRecall.RequestModel;
using BuildingBlock.Zones.Model.CRMIL.OrderRecall.ResponseModel;
using BuildingBlock.Zones.CRMIL.Repo.Helper;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Text;
using order1 = BuildingBlock.Zones.Model.OrderModel;
using System.IO;
using BuildingBlock.Zones.CRMIL.Model.Order;
using CRMIL.DA.Interfaces.AX.SalesOrder;
using BuildingBlock.Zones.CRMIL.Model.Order.Enums;

namespace BuildingBlock.Zones.CRMIL.Repo
{
    public class OrderRepository : IOrderRepository
    {
        private readonly IConfiguration _configuration;
        public OrderRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // We can add new methods specific to the repository here in the future
        public OrderDetail GetOrderById(string id)
        {
            return new OrderDetail { OrderId = id };
        }
		/// <summary>
		/// 
		/// </summary>
		/// <param name="oOrderDocument"></param>
		/// <returns></returns>
		public async Task<bool> SaveRecallOtherDocs(OrderDocument[] oOrderDocument)
		{
			SqlConnection conn = null;
			SqlTransaction transaction = null;

			try
			{
				//Get connection
				conn = new SqlConnection(_configuration["ZonesStorageConnectionString"]);
				conn.Open();

				//Begin transaction
				transaction = conn.BeginTransaction();

				for (int i = 0; i < oOrderDocument.Length; i++)
				{
					//Insert header record
					string sQuery = "INSERT INTO order_attachment_storage (order_no,doc_type,file_name,attached_by) VALUES(@order_no,@doc_type,@file_name,@attached_by) SELECT SCOPE_IDENTITY()";
					SqlCommand cmdHdr = new SqlCommand(sQuery, conn);
					cmdHdr.Transaction = transaction;
					cmdHdr.CommandType = CommandType.Text;
					cmdHdr.Parameters.Add("@order_no", SqlDbType.NVarChar, 255).Value = oOrderDocument[i].SalesID;
					cmdHdr.Parameters.Add("@doc_type", SqlDbType.NVarChar, 255).Value = oOrderDocument[i].DocumentTypeText;
					cmdHdr.Parameters.Add("@file_name", SqlDbType.NVarChar, 4000).Value = oOrderDocument[i].FileName;
					cmdHdr.Parameters.Add("@attached_by", SqlDbType.NVarChar, 255).Value = oOrderDocument[i].CreatedBy;
					long storageId = Convert.ToInt64(cmdHdr.ExecuteScalar());

					//Read file content
					//string sUploadRoot = System.Web.HttpContext.Current.Server.MapPath(ConfigurationManager.AppSettings["PODocumentsPath"].ToString());
					string sUploadRoot = _configuration["PODocumentsPath"];
					if (sUploadRoot != null && sUploadRoot != "" && !sUploadRoot.EndsWith("/"))
					{
						sUploadRoot = sUploadRoot + "/";
					}
					if (oOrderDocument[i].FolderName != null && oOrderDocument[i].FolderName != "" && !oOrderDocument[i].FolderName.EndsWith("/"))
					{
						oOrderDocument[i].FolderName = oOrderDocument[i].FolderName + "/";
					}
					string fileContent = ReadFile((sUploadRoot + oOrderDocument[i].FolderName + oOrderDocument[i].FileName));

					//Insert file content record
					sQuery = "INSERT INTO order_image_store(doc_storage_id,doc_image) VALUES (@po_storage_id,@doc_image)";
					SqlCommand cmdFile = new SqlCommand(sQuery, conn);
					cmdFile.Transaction = transaction;
					cmdFile.CommandType = CommandType.Text;
					cmdFile.Parameters.Add("@po_storage_id", SqlDbType.Int).Value = storageId;
					cmdFile.Parameters.Add("@doc_image", SqlDbType.Image).Value = Encoding.UTF8.GetBytes(fileContent); ;
					cmdFile.ExecuteNonQuery();

					try
					{
						UpdateAXPOComment(oOrderDocument[i].SalesID, oOrderDocument[i].CreatedBy, oOrderDocument[i].FileName, "Doc");
					}
					catch (Exception ex)
					{
						throw ex;
					}
				}

				//Commit transaction
				transaction.Commit();

			}
			catch (Exception ex)
			{
				transaction.Rollback();
			}
			finally
			{
				if (conn != null)
				{
					conn.Close();
					conn = null;
				}
			}
			return true;
		}
		private void UpdateAXPOComment(string p_sSalesID, string p_ZoneSalesResponsible, string fileName, string fileType)
		{
			// Read all the comments on the order
			// If a PO attachment comment is already added, do not add another PO comment
			// Else create a new PO comment

			OrderComment oComment = new OrderComment();
			oComment.RecIdSpecified = false;
			oComment.NoteType =AXNoteTypes.Zones;
			oComment.SalesID = p_sSalesID;
			oComment.Description = "Comment";

			oComment.Notes = fileType + " :" + fileName + " attached in CRM by " + p_ZoneSalesResponsible;
			oComment.User = p_ZoneSalesResponsible;

			//OrderComment[] oComments = SelectOrderComment(oComment);
			//bool hasPOComment = false;

			//if (oComments != null)
			//{
			//    for (int i = 0; i < oComments.Length; i++)
			//    {
			//        if (oComments[i].Notes != null)
			//        {
			//            if (oComments[i].Notes.ToLower().Contains("po attached in crm"))
			//            {
			//                hasPOComment = true;
			//                break;
			//            }
			//        }
			//    }
			//}

			//if (!hasPOComment)
			//{
			OrderComment[] oPOComments = new OrderComment[1];
			oPOComments[0] = oComment;
			AddOrderComment(oPOComments);
			//}
		}
		public void AddOrderComment(OrderComment[] p_oComment)
		{
			if (p_oComment.Length > 0)
			{
				for (int i = 0; i < p_oComment.Length; i++)
				{
					create(p_oComment[i].User, p_oComment[i].Description, p_oComment[i].Notes, "SalesId", p_oComment[i].SalesID, DocuRestriction.Internal, true, p_oComment[i].NoteType);
				}
			}
		}
		public async Task<AttachDocument> create( string Author,  string Description,  string Notes, string RelatedKey, string RelatedValue, DocuRestriction Restriction,  bool RestrictionSpecified,  string Type)
		{
            try
            {
				var res = new AttachDocument();
				HTTPClientWrapper<AttachDocument> hTTPClientWrapper = new HTTPClientWrapper<AttachDocument>(_configuration);

				var response = await hTTPClientWrapper.Get(_configuration.GetSection("getOrderLevelShipURL").Value);

				return res;
			}
			catch(Exception ex)
            {
				throw ex;
            }
		}
		/// <summary>
		/// Create Order
		/// </summary>
		/// <returns></returns>
		public async Task<bool> CreateOrder()
        {
            try
            {
				HTTPClientWrapper<AxdSalesOrder> hTTPClientWrapper = new HTTPClientWrapper<AxdSalesOrder>(_configuration);

				var response = await hTTPClientWrapper.Get(_configuration.GetSection("getOrderLevelShipURL").Value);
				return true;
			}
			catch (Exception ex)
            {
				throw ex;
            }
        }
		/// <summary>
		/// AddOrderAttachmentPOM ultiple
		/// </summary>
		/// <param name="p_Order"></param>
		/// <returns></returns>
		public async Task<order1.Order> AddOrderAttachmentPOMultiple( order1.Order p_Order)
		{
			SqlConnection conn = null;
			SqlTransaction transaction = null;

			try
			{
				//Get Zones_Storage database connection
				conn = new SqlConnection(_configuration["ZonesStorageConnectionString"] );
				conn.Open();
				string[] strArr = p_Order.POFileName;
				//Begin transaction
				transaction = conn.BeginTransaction();
				for (int i = 0; i < strArr.Length; i++)
				{
					//Insert header record
					string queryHdr = "INSERT INTO po_storage (order_no,po_num,file_name,attached_by) VALUES(@order_no,@po_num,@file_name,@attached_by) SELECT SCOPE_IDENTITY()";
					SqlCommand cmdHdr = new SqlCommand(queryHdr, conn);
					cmdHdr.Transaction = transaction;
					cmdHdr.CommandType = CommandType.Text;
					cmdHdr.Parameters.Add("@order_no", SqlDbType.NVarChar, 255).Value = p_Order.SalesID;
					cmdHdr.Parameters.Add("@po_num", SqlDbType.NVarChar, 255).Value = p_Order.AXSalesTable[0].PurchOrderFormNum;
					cmdHdr.Parameters.Add("@file_name", SqlDbType.NVarChar, 4000).Value = p_Order.POFileName[i].ToString();
					cmdHdr.Parameters.Add("@attached_by", SqlDbType.NVarChar, 255).Value = p_Order.CreatedBy;
					long storageId = Convert.ToInt64(cmdHdr.ExecuteScalar());

					//Read file content
					string sUploadRoot = _configuration["PODocumentsPath"]; 

					if (sUploadRoot != null && sUploadRoot != "" && !sUploadRoot.EndsWith("/"))
					{
						sUploadRoot = sUploadRoot + "/";
					}

					if (p_Order.POFolderName[i] != null && p_Order.POFolderName[i] != "" && !p_Order.POFolderName[i].EndsWith("/"))
					{
						p_Order.POFolderName[i] = p_Order.POFolderName[i] + "/";
					}

					string fileContent = ReadFile((sUploadRoot + p_Order.POFolderName[i].ToString() + p_Order.POFileName[i].ToString()));

					//Insert file content record
					string queryFile = "INSERT INTO po_image_store(po_storage_id,po_image) VALUES (@po_storage_id,@po_image)";
					SqlCommand cmdFile = new SqlCommand(queryFile, conn);
					cmdFile.Transaction = transaction;
					cmdFile.CommandType = CommandType.Text;
					cmdFile.Parameters.Add("@po_storage_id", SqlDbType.Int).Value = storageId;
					cmdFile.Parameters.Add("@po_image", SqlDbType.Image).Value = Encoding.UTF8.GetBytes(fileContent);
					cmdFile.ExecuteNonQuery();
				}

				//Commit transaction
				transaction.Commit();
				
			}
			catch (SqlException _x)
			{
				transaction.Rollback();
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				if (conn != null)
				{
					conn.Close();
					conn = null;
				}
			}
			return p_Order;
		}
		private String ReadFile(string filePath)
		{
			StringBuilder sb = new StringBuilder();
			using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
			{
				for (int i = 0; i < fileStream.Length; i++)
				{
					int ch = fileStream.ReadByte();
					sb.Append((char)ch);
				}
			}
			return sb.ToString();
		}
		

		/// <summary>
		///  Get Order recall data
		/// </summary>
		/// <param name="orderRecallQuery"></param> 
		/// <returns></returns>
		public async Task<List<OrderResponseData>> GetOrderRecall(OrderRecallQuery orderRecallQuery)
		{
			HTTPClientWrapper<List<OrderResponseData>> hTTPClientWrapper = new HTTPClientWrapper<List<OrderResponseData>>(_configuration);
			var response = await hTTPClientWrapper.PostRequest(_configuration.GetSection("OrderDetailURL").Value, orderRecallQuery);
			return response;
		}

	}
}
