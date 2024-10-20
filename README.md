# Patika+ Week4 Abstract Uygulaması
Merhaba,
Bu proje C# ile Patika+ 4.hafta Abstract için yapılmış bir uygulamadır.

## 📚 Proje Hakkında
Bu proje, aşağıdaki konuları öğrenmeye yardımcı olmak için tasarlanmıştır:
- Basit bir C# programı yazmak
- C# konsol uygulamasının yapısını anlamak
- Method kullanımı ve yapısını anlamak.
- Class yapısını anlamak
- Encapsulation yapısını öğrenmek
- Inheritance Method yapısını öğrenmek
- Polymorphism
- Abstract

## İstenilen Görev
Düşünün ki bir şirketin çalışanlarını temsil eden bir program yazıyorsunuz.
Her çalışan için ad, soyad, departman gibi ortak özellikler bulunmaktadır
Ancak her çalışanın görevi (pozisyonu) farklı olabilir (Örneğin, Yazılım Geliştirici, Proje Yöneticisi, Satış Temsilcisi).
Gorev metodunu çağırdığımızda her çalışan kendi yaptığı işi konsol ekranında söyleyecek.
Örneğin
Hasan Çıldırmış şirketin Proje yönetcisi, kendisi üzerinden Gorev() abstract metodu çağırıldığında konsol ekranında
" Proje yöneticisi olarak çalışıyorum. " yazdırılmasını istiyoruz.


## Kod
```csharp
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
```
Interface, abstract class tanımlandı. Kalıtım kullanıldı

```csharp
 static void Main(string[] args)
 {
     Employee employee = new Employee("Yaşar", "Doğan", "Yazılım Mühendisi");
     employee.PerformTask();

     Console.WriteLine("\r\n*********************************************************\r\n");

     Employee employee2 = new Employee("Hasan", "Çıldırmış", "Proje Yöneticisi");
     employee2.PerformTask();
 }
```
Main method içinde sınıftan nesneler oluşturuldu.



