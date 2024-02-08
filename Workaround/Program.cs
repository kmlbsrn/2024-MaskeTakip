using Business.Concrete;
using Entities.Concrete;
using System;

Vatandas vatandas = new Vatandas();
vatandas.Ad = "kemal";
SelamVer(isim: "Kemal");

int sonuc = Topla(sayi1: 5, sayi2: 6);

List<string> ogrencilerr = new List<string>();

string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };

foreach (string s in sehirler1)
{
    Console.WriteLine(s);
}



Person person1 = new Person();
person1.FirstName = "Kemal";
person1.LastName = "Başaran";
person1.DateOfBirthYear = 2002;
person1.NationalIdentity = 123;

Person person2 = new Person();
person2.FirstName = "Aysel";

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);

static void SelamVer(string isim)
{
    Console.WriteLine("Merhaba" + isim);
}
static int Topla(int sayi1, int sayi2)
{
    int sonuc = sayi1 + sayi2;
    Console.WriteLine("Toplam: " + sonuc.ToString());
    return sonuc;
}


public class Vatandas
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int DogumYili { get; set; }
}