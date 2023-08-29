using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace PROJEKTPOPRAWA.UnitTests
{
    [TestFixture]
    public class Form1Tests
    {
        [Test]
        public void TestAddingExpensesAndCalculatingTotal()
        {
            // Arrange
            var form = new Form1();

            // Act
            form.expenses.Add(50); // Dodajmy wydatek 50
            form.expenses.Add(100); // Dodajmy wydatek 100
            form.CalculateTotal(); // Obliczmy sumę

            // Assert
            Assert.AreEqual("SUMA: 150,00 zł", form.totalLabel.Text);
        }
    }
}