namespace EmployeeSystem
{
    public class Branche
    {
        public string Name { get; set; }

        public double Katsayi { get; set; }

        public Branche(string name,double katsayi)
        {
            Name= name;
            Katsayi = katsayi;
        }
    }
}