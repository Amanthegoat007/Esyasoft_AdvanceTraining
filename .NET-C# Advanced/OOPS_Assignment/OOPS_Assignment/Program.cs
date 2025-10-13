namespace OOPS_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Task1
            ////Console.WriteLine("Hello, World!");
            //Meter m1 = new Meter("AP-0001", "Feeder-12");
            //Meter m2 = new Meter("AP-0002", "DTR-9");
            //m1.AddReading(15230);m1.AddReading(-1121);
            //m2.AddReading(9800);
            //Console.WriteLine(m1.Summary());
            //Console.WriteLine(m2.Summary());

            //Task-2
            Tariff t1 = new Tariff("Tarrif1");
            Tariff t2 = new Tariff("Tarrif2",5.0);
            Tariff t3 = new Tariff("Tarrif3",4.0,65);
            Tariff t4 = new Tariff("Tarrif3",-4.0);
            t1.ComputeBill(120);
            t2.ComputeBill(120);
            t3.ComputeBill(120);
            t4.ComputeBill(120);
        }
    }
}
