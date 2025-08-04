using BethanysPieShopHRM.Shared.Domain;
using PieShopHRM.Services;
using System.Runtime.CompilerServices;

namespace PieShopHRM.Components.Pages
{
    public partial class EmployeeOverview
    {
        public List<Employee>? Employees { get; set; } = null;

        private Employee? _selectedEmployee = null;

        protected async override Task OnInitializedAsync()
        {
            Employees = MockDataService.Employees;
        }

        public void ShowQuickViewPopup(Employee employee)
        {
            _selectedEmployee = employee;
        }
    }
}
