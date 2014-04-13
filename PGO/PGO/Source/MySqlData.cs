using System;
using System.Data;

namespace PGO.Source
{
    /// <summary>
    /// Набор компонент для простой работы с MySQL базой данных.
    /// </summary>
    public class MySqlData
    {
        public static string ConnectionString;
        /// <summary>
        /// Методы реализующие выполнение запросов с возвращением одного параметра либо без параметров вовсе.
        /// </summary>
        public class MySqlExecute
        {

            /// <summary>
            /// Возвращаемый набор данных.
            /// </summary>
            public class MyResult
            {
                /// <summary>
                /// Возвращает результат запроса.
                /// </summary>
                public string ResultText;
                /// <summary>
                /// Возвращает True - если произошла ошибка.
                /// </summary>
                public string ErrorText;
                /// <summary>
                /// Возвращает текст ошибки.
                /// </summary>
                public bool HasError;
            }

            /// <summary>
            /// Для выполнения запросов к MySQL с возвращением 1 параметра.
            /// </summary>
            /// <param name="sql">Текст запроса к базе данных</param>
            /// <returns>Возвращает значение при успешном выполнении запроса, текст ошибки - при ошибке.</returns>
            public static MyResult SqlScalar(string sql)
            {
                var result = new MyResult();
                try
                {
                    var connRC = new MySql.Data.MySqlClient.MySqlConnection(ConnectionString);
                    var commRC = new MySql.Data.MySqlClient.MySqlCommand(sql, connRC);
                    connRC.Open();
                    try
                    {
                        result.ResultText = commRC.ExecuteScalar().ToString();
                        result.HasError = false;
                    }
                    catch (Exception ex)
                    {
                        result.ErrorText = ex.Message;
                        result.HasError = true;
                    }
                    connRC.Close();
                }
                catch (Exception ex)//Этот эксепшн на случай отсутствия соединения с сервером.
                {
                    result.ErrorText = ex.Message;
                    result.HasError = true;
                }
                return result;
            }


            /// <summary>
            /// Для выполнения запросов к MySQL без возвращения параметров.
            /// </summary>
            /// <param name="sql">Текст запроса к базе данных</param>
            /// <returns>Возвращает True - ошибка или False - выполнено успешно.</returns>
            public static MyResult SqlNoneQuery(string sql)
            {
                var result = new MyResult();
                try
                {
                    var connRC = new MySql.Data.MySqlClient.MySqlConnection(ConnectionString);
                    var commRC = new MySql.Data.MySqlClient.MySqlCommand(sql, connRC);
                    connRC.Open();
                    try
                    {
                        commRC.ExecuteNonQuery();
                        result.HasError = false;
                    }
                    catch (Exception ex)
                    {
                        result.ErrorText = ex.Message;
                        result.HasError = true; 
                    }
                    connRC.Close();
                }
                catch (Exception ex)//Этот эксепшн на случай отсутствия соединения с сервером.
                {
                    result.ErrorText = ex.Message;
                    result.HasError = true;
                }
                return result;
            }
             
        }

        /// <summary>
        /// Методы реализующие выполнение запросов с возвращением набора данных.
        /// </summary>
        public class MySqlExecuteData
        {
            /// <summary>
            /// Возвращаемый набор данных.
            /// </summary>
            public class MyResultData
            {
                /// <summary>
                /// Возвращает результат запроса.
                /// </summary>
                public DataTable ResultData;
                /// <summary>
                /// Возвращает True - если произошла ошибка.
                /// </summary>
                public string ErrorText;
                /// <summary>
                /// Возвращает текст ошибки.
                /// </summary>
                public bool HasError;
            }


            /// <summary>
            /// Выполняет запрос выборки набора строк.
            /// </summary>
            /// <param name="sql">Текст запроса к базе данных</param>
            /// <returns>Возвращает набор строк в DataSet.</returns>
            public static MyResultData SqlReturnDataset(string sql)
            {
                var result = new MyResultData();
                try
                {
                    var connRC = new MySql.Data.MySqlClient.MySqlConnection(ConnectionString);
                    var commRC = new MySql.Data.MySqlClient.MySqlCommand(sql, connRC);
                    connRC.Open();

                    try
                    {
                        var adapterP = new MySql.Data.MySqlClient.MySqlDataAdapter
                        {
                            SelectCommand = commRC
                        };
                        var ds1 = new DataSet();
                        adapterP.Fill(ds1);
                        result.ResultData = ds1.Tables[0];
                    }
                    catch (Exception ex)
                    {
                        result.HasError = true;
                        result.ErrorText = ex.Message;
                    }
                    connRC.Close();
                }
                catch (Exception ex)//Этот эксепшн на случай отсутствия соединения с сервером.
                {
                    result.ErrorText = ex.Message;
                    result.HasError = true;
                }
            
                return result;

            }

        }
    }
}
