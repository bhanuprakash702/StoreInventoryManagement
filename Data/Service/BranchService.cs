using InventoryManagement.Data.DataAccessLayer;
using InventoryManagement.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InventoryManagement.Data.Service
{
    public class BranchService
    {
        BranchDataAccessLayer obj = new BranchDataAccessLayer();
        public string Create(BranchDetails objBranch)
        {
            obj.AddBranch(objBranch);
            return "Added Successfully";
        }
    }
}
