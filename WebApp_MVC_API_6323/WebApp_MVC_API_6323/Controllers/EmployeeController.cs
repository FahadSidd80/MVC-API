using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using WebApp_MVC_API_6323.Models;
using Newtonsoft.Json;


namespace WebApp_MVC_API_6323.Controllers
{
    public class EmployeeController : ApiController // Employee -- is called as API Controller Class
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["abc"].ConnectionString);

       
        [HttpPost]
        public void EmployeeInsert([FromBody] Employee obj) // EmployeeInsert -- is called API Method
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_tblEmployee_insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", obj.name);
            cmd.Parameters.AddWithValue("@city", obj.city);
            cmd.Parameters.AddWithValue("@age", obj.age);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        [HttpGet]
        public string EmployeeGet() // EmployeeGet -- is called API Method
        {
            string data = "";
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_tblEmployee_get", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            data = JsonConvert.SerializeObject(dt);
            return data;
            
        }
    }
}
