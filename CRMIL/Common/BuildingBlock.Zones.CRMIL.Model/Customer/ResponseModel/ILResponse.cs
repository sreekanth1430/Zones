using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlock.Zones.Model.Customer.ResponseModel
{
    public class ILResponse
    {
		public ILResponse()
		{
			Data = new List<Object>();
		}

		public string MessageCode { get; set; }

		public string MessageText { get; set; }

		public EnumMessageType MessageType { get; set; }

		public List<Object> Data { get; set; }

		public string TransactionID { get; set; }

		public string HttpMethod { get; set; }

		public string API { get; set; }

		public bool HasException { get; set; }

		public string Exception { get; set; }

		public string Html
		{
			get
			{
				if (!String.IsNullOrEmpty(MessageCode))
					FormatHtml("code", MessageCode);
				if (!String.IsNullOrEmpty(Exception))
					FormatHtml("exception", Exception.ToString());
				if (!String.IsNullOrEmpty(MessageText))
					FormatHtml("text", MessageText);
				if (!String.IsNullOrEmpty(TransactionID))
					FormatHtml("transaction", TransactionID);
				FormatHtml("type", MessageType.ToString());
				FormatHtml("hasexception", HasException.ToString());
				return sHTML;
			}
			set
			{
				sHTML = value;
			}
		}

		public void Add(Object p_Object)
		{
			Data.Add(p_Object);
		}

		#region StaticFactoryMembers

		public static ILResponse GetSuccessResponse(String Message = null)
		{
			var response = new ILResponse();

			response.HasException = false;
			response.MessageType = EnumMessageType.OPERATION_SUCCESS;
			response.MessageText = Message != null ? Message : "Operation completed successfully!";

			return response;
		}

		public static ILResponse GetSuccessResponse(Object ResponseData, String Message = null)
		{
			var response = new ILResponse();

			response.HasException = false;
			response.MessageType = EnumMessageType.OPERATION_SUCCESS;
			response.MessageText = Message != null ? Message : "Operation completed successfully!";
			response.Data.Add(ResponseData);

			return response;
		}
		public static ILResponse GetSuccessResponse(Object ResponseData, EnumMessageType messageType, String Message = null)
		{
			var response = new ILResponse();

			response.HasException = false;
			response.MessageType = messageType;
			response.MessageText = Message != null ? Message : "Operation completed successfully!";
			response.Data.Add(ResponseData);

			return response;
		}
		public static ILResponse GetErrorResponse(Exception Exception)
		{
			if (Exception is System.ApplicationException)
			{
				return GetErrorResponse(Exception.Message, Exception, EnumMessageType.OPERATION_APPLICATION_ERROR);
			}
			else
			{
				return GetErrorResponse("Operation failed!", Exception, EnumMessageType.OPERATION_TECHNICAL_ERROR);
			}
		}

		public static ILResponse GetErrorResponse(String ErrorMessage, Exception Exception = null, EnumMessageType ErrorType = EnumMessageType.OPERATION_TECHNICAL_ERROR)
		{
			var response = new ILResponse();

			response.HasException = true;
			response.MessageType = ErrorType;
			response.MessageText = ErrorMessage;
			response.Exception = Exception != null ? Exception.ToString() : null;
			response.Data = null;

			return response;
		}

		public static ILResponse GetErrorResponse(Object ResponseData, String ErrorMessage, Exception Exception = null, EnumMessageType ErrorType = EnumMessageType.OPERATION_TECHNICAL_ERROR)
		{
			var response = new ILResponse();

			response.HasException = true;
			response.MessageType = ErrorType;
			response.MessageText = ErrorMessage;
			response.Exception = Exception != null ? Exception.ToString() : null;
			response.Data.Add(ResponseData);

			return response;
		}

		#endregion StaticFactoryMembers

		#region PrivateMembers

		private void FormatHtml(string Key, string Value)
		{
			switch (Key)
			{
				case "code":
					sHTML = sHTML.Replace("@@code", Value);
					break;
				case "exception":
					sHTML = sHTML.Replace("@@exception", Value);
					break;
				case "text":
					sHTML = sHTML.Replace("@@text", Value);
					break;
				case "type":
					sHTML = sHTML.Replace("@@type", Value);
					break;
				case "transaction":
					sHTML = sHTML.Replace("@@transaction", Value);
					break;
				case "hasexception":
					sHTML = sHTML.Replace("@@hasexception", Value);
					break;
			}
		}

		private string sHTML = "<table><tr><td>Transaction #</td><td>@@transaction</td></tr><tr><td>Has Error</td><td>@@hasexception</td></tr><tr><td>Response Text</td><td>@@text</td></tr><tr><td>Response Type</td><td>@@type</td></tr><tr><td>Exception</td><td>@@exception</td></tr>";

		#endregion PrivateMembers
	}

	public enum EnumMessageType
	{
		OPERATION_SUCCESS = 1, OPERATION_TECHNICAL_ERROR = 2, OPERATION_APPLICATION_ERROR = 3, OPERATION_VALIDATION_ERROR = 4, OPERATION_SUCCESS_WITH_WARNING = 5
	}

}

