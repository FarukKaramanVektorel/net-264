using System.ComponentModel;

var user =new { Ad = "Ayşe", Yas = 10, Sehir = "Adana" };

Console.WriteLine($"{user.Ad}, {user.Yas}, {user.Sehir}");

var users = new[]
{
    new { Ad = "Ayşe", Yas = 10, Sehir = "Adana" },
    new { Ad = "Ali", Yas = 8, Sehir = "Adana" },
    new { Ad = "Kerim", Yas = 10, Sehir = "Adana" }

};

var userFilter=users.Where(u=>u.Yas>9).ToList();
Console.WriteLine(string.Join(", ", userFilter));
var urun = new Urun { Ad = "Eti Karam", Fiyat=45.99};
var name = new { urun.Ad };
class Urun
{
    public string Ad { get; set; }
    public double Fiyat { get; set; }
}