using System.Collections.Generic;

namespace DomainModel
{
    public class Store
    {
        public virtual int Id { get; private set; }
        public virtual string Name { get; set; }
        public virtual IList<Product> Products { get; set; }
        public virtual IList<Employee> Employees { get; set; }

        public Store()
        {
            Products = new List<Product>();
            Employees = new List<Employee>();
        }

        public void AddProduct(Product product)
        {
            product.StoresStockedIn.Add(this);
            Products.Add(product);
        }

        public void AddEmployee(Employee employee)
        {
            employee.Store = this;
            Employees.Add(employee);
        }
    }
}