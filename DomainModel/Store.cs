using System.Collections.Generic;

namespace DomainModel
{
    public class Store
    {
        public virtual int Id { get; protected set; }
        public virtual string Name { get; set; }
        public virtual IList<Product> Products { get; set; }
        public virtual IList<Employee> Employees { get; set; }

        public Store()
        {
            Products = new List<Product>();
            Employees = new List<Employee>();
        }

        public virtual void AddProduct(Product product)
        {
            product.StoresStockedIn.Add(this);
            Products.Add(product);
        }

        public virtual void AddEmployee(Employee employee)
        {
            employee.Store = this;
            Employees.Add(employee);
        }
    }
}