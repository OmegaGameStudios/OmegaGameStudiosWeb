using Microsoft.AspNetCore.Components;
using OmegaGameStudios.Shared.Domain;
using OmegaGameStudios.Shared.Models;
namespace OmegaGameStudios_App.Pages
{
    public partial class EmployeeOverview : ComponentBase
    {
        public List<Employee> Employees { get; set; } = default!;
 
        protected override void OnInitialized()
        {
            base.OnInitialized();
        }
    }

}
