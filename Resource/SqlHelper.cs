using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfNorthwindApp.Resource
{
    public static class SqlHelper
    {
        public static int? GetNullableInt(SqlDataReader dr, string columnName)
        {
            return (int?)(dr[columnName] == DBNull.Value ? null : dr[columnName]);
        }

        public static Int16? GetNullableInt16(SqlDataReader dr, string columnName)
        {
            return (Int16?)(dr[columnName] == DBNull.Value ? null : dr[columnName]);
        }

        public static decimal? GetNullableDecimal(SqlDataReader dr, string columnName)
        {
            return (decimal?)(dr[columnName] == DBNull.Value ? null : dr[columnName]);
        }

        public static string GetNullableString(SqlDataReader dr, string columnName)
        {
            return (dr[columnName] == DBNull.Value ? "" : (string)(dr[columnName]));
        }

        public static DateTime? GetNullableDateTime(SqlDataReader dr, string columnName)
        {
            if (dr[columnName] == DBNull.Value)
            {
                return null;
            }
            else
            {
                return (DateTime)dr[columnName];
            }
        }

        public static byte[] GetNullableByteArray(SqlDataReader dr, string columnName)
        {
            if (dr[columnName] == DBNull.Value)
            {
                return null;
            }
            else
            {
                return (byte[])dr[columnName];
            }
        }
    }
}
