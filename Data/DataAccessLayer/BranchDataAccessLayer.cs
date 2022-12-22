using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryManagement.Data.Models;
using Microsoft.Data.SqlClient;

namespace InventoryManagement.Data.DataAccessLayer
{
    public class BranchDataAccessLayer
    {
        string connectionString = "data source=DESKTOP-3ES5VPE;initial catalog=InventoryManagement;TrustServerCertificate=True";
        //To Add new Branch record    
        public void AddBranch(BranchDetails Branch)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SP_InsertBranch", con);
                //cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@Name", Branch.BranchName);
                //cmd.Parameters.AddWithValue("@id", Branch.BranchId);
                //cmd.Parameters.AddWithValue("@isActive", Branch.IsActive);

                
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
