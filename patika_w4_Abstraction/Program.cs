namespace patika_w4_Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Yaşar", "Doğan", "Yazılım Mühendisi");
            employee.PerformTask();

            Console.WriteLine("\r\n*********************************************************\r\n");

            Employee employee2 = new Employee("Hasan", "Çıldırmış", "Proje Yöneticisi");
            employee2.PerformTask();
        }
    }
}
