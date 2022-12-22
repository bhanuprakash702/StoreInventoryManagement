using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.Data.Models
{
    public class BranchDetails
    {
        public string? BranchId { get; set; }
        public string? BranchName { get; set; }
        public string? IsActive { get; set; }

    }
}
