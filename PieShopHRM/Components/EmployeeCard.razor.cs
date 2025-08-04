using PieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace PieShopHRM.Components
{
    public partial class EmployeeCard
    {
        [Parameter]
        public Employee Employee { get; set; } = new Employee();

        [Parameter]
        public EventCallback<Employee> EmployeeQuickViewClicked { get; set; }
    }
}
