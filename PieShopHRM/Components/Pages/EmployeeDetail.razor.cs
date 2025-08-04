using PieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;
using PieShopHRM.Services;

namespace PieShopHRM.Components.Pages
{
    public partial class EmployeeDetail
    {
        [Parameter]
        public int EmployeeId { get; set; }

        public Employee Employee { get; set; } = new Employee();

        protected override async Task OnInitializedAsync()
        {
            Employee = MockDataService.Employees?.FirstOrDefault(e => e.EmployeeId == EmployeeId);
        }

        private void ChangeHolidayState()
        {
            Employee.IsOnHoliday = !Employee.IsOnHoliday;
        }
    }
}
