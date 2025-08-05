using PieShopHRM.Services;

namespace PieShopHRM.Tests
{
    /// <summary>
    /// Tests for the MockDataService class.
    /// Note that this is a placeholder for actual unit tests, just to demonstrate CI/CD setup.
    /// This class should be replaced with meaningful tests as the application develops.
    /// </summary>
    public class MockDataServiceTests
    {
        [Fact]
        public void MockDataServiceHasData()
        {
            var employees = MockDataService.Employees;

            Assert.NotNull(employees);
            Assert.True(employees.Count > 0, "Employee list should not be empty.");
        }
    }
}