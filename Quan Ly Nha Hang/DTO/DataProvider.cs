using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Quan_Ly_Nha_Hang.DTO
{
    public class DataProvider
    {
        private static DataProvider instance;
        public static DataProvider Instance {
            get
            {
                if (instance == null) instance = new DataProvider();
                return DataProvider.instance;
            }
            private set => instance = value; 
        }

        private DataProvider() { }

        private string connectionSTR = @"Data Source=.\sqlexpress;Initial Catalog=Quản Lý Nhà Hàng;Integrated Security=True";

        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                if(parameter!= null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string items in listPara)
                    {
                        if(items.Contains('@'))
                        {
                            command.Parameters.AddWithValue(items, parameter[i]);
                            i++;
                        }
                    }
                }
               
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                connection.Close();
            }//Dùng using để khi kết thúc khối lệnh thì đối tượng được khai báo sẽ được giải phóng
            return data;
        }//Trả ra dòng kết quả
        //parameter han che SQLInjection

        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string items in listPara)
                    {
                        if (items.Contains('@'))
                        {
                            command.Parameters.AddWithValue(items, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteNonQuery();

                connection.Close();
            }
            return data;
        }//Trả ra số đòng được thực thi

        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string items in listPara)
                    {
                        if (items.Contains('@'))
                        {
                            command.Parameters.AddWithValue(items, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();

                connection.Close();
            }//Dùng using để khi kết thúc khối lệnh thì đối tượng được khai báo sẽ được giải phóng
            return data;
        }//Trả ra số kết quả
    }
}
