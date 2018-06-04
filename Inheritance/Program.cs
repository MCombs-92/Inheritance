using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance {
	class Program {
		static void Main(string[] args) {

			Employee e1 = new Employee();
			e1.Name = "E1";
			e1.Position = "flunky";
			e1.Salary = 5999;
			e1.VacationDays = 0;
			//e1.Print();

			Manager m1 = new Manager();
			m1.Name = "M1";
			m1.Position = "Supervisor";
			m1.Salary = 5998;
			m1.VacationDays = 1;
			m1.PurchaseAuth = 10.99M;
			//m1.Print();

			Administrator a1 = new Administrator();
			a1.Name = "A1";
			a1.Position = "Administrator";
			a1.Salary = 10000;
			a1.VacationDays = 10;
			a1.AssignedTo = m1;

			//Employee m2 = new Manager();
			//m2.Name = "M2";
			//m2.Position = "Supervisor";
			//m2.Salary = 6000;
			//m2.VacationDays = 2;

			e1.Manager = m1;

			 
			List<Employee> Employees = new List<Employee>();

			Employees.Add(e1);
			Employees.Add(m1);
			Employees.Add(a1);

			//foreach(Employee employees in Employees) {
			//	employees.Salary += 500;
			//}

			foreach(Employee employee in Employees) {
				string msg = employee.Print();
				Console.WriteLine(msg);
			}
		}
	}
}
