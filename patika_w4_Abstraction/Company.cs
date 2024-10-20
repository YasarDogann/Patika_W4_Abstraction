using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patika_w4_Abstraction
{
    //IDepartment arayüzü: tüm departmanlar için bir görev methodu tanımlar
    public interface IDepartment
    {
        void PerformTask();  // Görev Methodu tanımlanması
    }

    // Company sınıfı : Tüm çalışanlar için ortak özellikleri barındıran abstract bir sınıf
    public abstract class Company : IDepartment
    {
        // Çalışan için ad soyad ve pozisyon için ortak özellikler (Properties)
        public string Name { get; set; }
        public string LastName {  get; set; }
        public string Position { get; set; }


        // Company sınıfı yapıcı methodu.
        public Company(string name, string lastname,string position)
        {
            Name = name;
            LastName = lastname;
            Position = position;
        }

        // soyut görev methodu: türeyen sınıflar tarafından kullanılmak zorundadır.
        public abstract void PerformTask();
    }


    // Employee sınıfı: Company sınıfından miras almıştır. Çalışan için özel görev davranışını tanımlar
    public class Employee : Company
    {
        // Emplooye yapıcı methodu: Company sınıfı yapıcı methoduna parametreleri iletir.
        public Employee(string name, string lastname,string position) : base(name, lastname, position) { }

        // PerformTask methodu override eder. Çalışanın isim soyisim ve görevini ekrana yazdırır.
        public override void PerformTask()
        {
            Console.WriteLine($"{Name} {LastName} şirketin {Position} olarak çalışıyor");
        }
    }
}
