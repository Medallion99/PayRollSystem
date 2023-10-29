global using Xunit;
using MainPayRoll.Model;

namespace Payroll.Test
{
    public class PayrollManagerTest
    {
        [Fact]
        public void Employee_CalculatePayroll_CalculatePayrollCorrectly()
        {
            // Arrange
            var employee = new Employee(regularRate: 10.0, overtimeRate: 15.0);
            employee.IsActive = true;
            employee.RegularHours = 40.0;
            employee.OvertimeHours = 5.0;

            // Act
            employee.CalculatePayroll();

            // Assert
            // You can use xUnit assertions to check the expected values.
            Assert.Equal(475.0, employee.GrossPay); // Expected Gross Pay
            Assert.Equal(9.5, employee.MedicareDeduction); // Expected Medicare Deduction
            Assert.Equal(23.75, employee.RentDeduction); // Expected Rent Deduction
            Assert.Equal(14.25, employee.FoodDeduction); // Expected Food Deduction
            Assert.Equal(427.5, employee.NetPay); // Expected Net Pay

        }
    }
}