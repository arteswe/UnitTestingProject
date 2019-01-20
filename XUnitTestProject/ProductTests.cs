using UnitTestingProject.Models;
using Xunit;

namespace XUnitTestProject
{
    public class ProductTests
    {
        [Fact]
        public void CanChangeName()
        {
            var p = new Product {Name = "TestName", Price = 100M};
            p.Name = "NameTest";
            Assert.Equal("NameTest", p.Name);
        }
        [Fact]
        public void CanChangePrice()
        {
            var p = new Product { Name = "TestName", Price = 100M };
            p.Price = 40M;
            Assert.Equal(40M, p.Price);
        }
    }
}
