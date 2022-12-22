using InventoryManagement.Data.Models;
using Microsoft.AspNetCore.Components;
using InventoryManagement.Data.Service;

namespace InventoryManagement.Pages
{
    public partial class Branch
    {
        BranchDetails obj = new BranchDetails();
        protected void CreateBranch()
        {
            objBranchService.Create(obj);
        }

    }
}
