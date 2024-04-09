namespace SistemaDePagamentos.Entities
{
    public class OutsourcedEmployee : Employee
    {
        public double additionalCharge { get; set; }

        public OutsourcedEmployee () { }

        public OutsourcedEmployee(string? name, int hours, double valuePerHour, double additionalCharge) : base(name, hours,valuePerHour)        {
            this.additionalCharge = additionalCharge;
        }

        public override double payment()
        {

            return base.payment() + 1.1 * additionalCharge;
        }
    }
}
