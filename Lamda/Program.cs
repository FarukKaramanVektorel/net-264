using System;
using System.Threading.Channels;

// (girilen değerler) => yapılacak işlemi

Func<int,int, double> karesiniVer = (x,y) => x * y*0.5;
Func<int, int, int> buyukSayiyiBul = (x, y) =>
{
    int buyukSayi = y;
    if (x > y) buyukSayi = x;
    return buyukSayi;
};
Func<string> sayHello = () => "Merhaba dünya";
Console.WriteLine(sayHello());

Action<string> ekranaBas = s => Console.WriteLine(s);
ekranaBas("Bugün 21 Eylül 2026 Pazartesi");
Action sayHello2 = () => Console.WriteLine("Merhaba Dünya!!!");
sayHello2();

Console.WriteLine(buyukSayiyiBul(891,218));
Console.WriteLine(kareVer(89));


Predicate<int> sayiPozitifMi = n => n > 0;
Predicate<int> ciftSayiMi = n => n %2== 0;

Console.WriteLine(sayiPozitifMi(-89));
Console.WriteLine(sayiPozitifMi(89));
Console.WriteLine(ciftSayiMi(89));
Console.WriteLine(ciftSayiMi(86));

List<int> list = new List<int> {1,3,9,8,12,44,92,56,37 };

var ciftSayilar = list.Where(n => n % 2 == 0).ToList();
Console.WriteLine(string.Join(", ", ciftSayilar));





double kareVer(double a)
{
    return a * a;
}
