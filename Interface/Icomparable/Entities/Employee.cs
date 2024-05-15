namespace Icomparable.Entities
{
    public class Employee : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string csvEmployee) {
            string[] strings = csvEmployee.Split(',');
            Name = strings[0];
            Salary = double.Parse(strings[1]);
        }

        public override string ToString()
        {
            return $"{Name}, {Salary}";
        }
        int  IComparable.CompareTo(object? obj)
        {
            if (!(obj is Employee)) {

                 throw new ArgumentException("Comparing error : argument is not an Employee");
            }
              
            Employee other = (Employee)obj;

            return Name.CompareTo(other.Name);
                

            
        }
    }
}
