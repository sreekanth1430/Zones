using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlock.Zones.CRMIL.Repo.Oracle
{
    public class DataAccessORA
    {
        private readonly IConfiguration _configuration;

        public DataAccessORA()
        {
        }

        public DataAccessORA(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public DataSet Select(string p_ProcedureName, Dictionary<string, string> p_Parameters, int iRetCursorCount = 1)
        {
            DataSet dsReturn = new DataSet();
            //var connstring = _configuration.GetSection("ORAConnectionString").Value;
            var connstring = "User ID=crmildev; Password=bqpr33; Pooling=true; Min Pool Size=0; Max Pool Size=150; Connection Lifetime=0; Connection Timeout=60; Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=tcp) (HOST=devdb.zones.internal)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=B2BDEVDB)))";
            OracleConnection OraConnection = new OracleConnection(connstring);
            try
            {
                OracleCommand oCommand = new OracleCommand(p_ProcedureName);
                oCommand.CommandType = CommandType.StoredProcedure;

                OracleParameter oOraParameter = null;
                if (p_Parameters != null)
                {
                    foreach (KeyValuePair<string, string> item in p_Parameters)
                    {
                        oOraParameter = new OracleParameter();
                        oOraParameter.OracleDbType = OracleDbType.NVarchar2;
                        oOraParameter.ParameterName = item.Key;
                        oOraParameter.Value = item.Value;
                        oOraParameter.Direction = ParameterDirection.Input;
                        oCommand.Parameters.Add(oOraParameter);
                    }
                }
                for (int i = 0; i < iRetCursorCount; i++)
                {
                    OracleParameter oOraRetParameter = new OracleParameter();
                    oOraRetParameter.OracleDbType = OracleDbType.RefCursor;
                    oOraRetParameter.Direction = ParameterDirection.Output;
                    oCommand.Parameters.Add(oOraRetParameter);
                }

                //Open connection
                OraConnection.Open();
                oCommand.Connection = OraConnection;
                OracleDataAdapter oAdapter = new OracleDataAdapter(oCommand);
                oAdapter.Fill(dsReturn);

                //Close Connection
                OraConnection.Close();
                OraConnection.Dispose();
                OraConnection = null;
            }
            catch (Exception io)
            {
                if (OraConnection != null)
                {
                    OraConnection.Close();
                    OraConnection.Dispose();
                    OraConnection = null;
                }
                throw io;
            }
            return dsReturn;
        }
    }
}
