

int number = 9;
number = 8;
number = -9;

HesaplaVeYazdir(9, 3, Topla);
HesaplaVeYazdir(9, 3, Cikar);
HesaplaVeYazdir(9, 3, Carp);
HesaplaVeYazdir(9, 3, Bol);

Islem islem = KareAl;
islem(5);
islem = KupAl;
islem(5);
MatematikselIslem mislem = Topla;//9
mislem += Bol;//1
mislem += Cikar;//1
mislem += Carp;//20

Console.WriteLine("Delegate işlem sonucu: "+ mislem(5, 4)); 

Bildirim system = EpostaGonder;//89
system += SmsGonder;//15
system += LogYaz;//964
system("Siparişiniz Kargoya Verildi");
system -= SmsGonder;
system("Siparişiniz Yola Çıktı");
void KareAl(int sayi)
{
    Console.WriteLine(sayi*sayi);
}
void KupAl(int sayi)
{
    Console.WriteLine(sayi * sayi*sayi);
}

int HesaplaVeYazdir(int x,int y,MatematikselIslem islem1)
{
    int sonuc=islem1(x,y);
    Console.WriteLine($"Sonuç: {sonuc}");
    return sonuc;
}
int Topla(int a, int b) => a + b;
int Carp(int a, int b) => a * b;
int Cikar(int a, int b) => a - b;
int Bol(int a, int b) => a / b;
void EpostaGonder(string mesaj) => Console.WriteLine("[E-POSTA] "+mesaj);
void SmsGonder(string mesaj) => Console.WriteLine("[SMS] "+mesaj);
void LogYaz(string mesaj) => Console.WriteLine("[LOG] "+mesaj);
delegate void Islem(int sayi);
delegate int MatematikselIslem(int sayi,int sayi2);
delegate void Bildirim(string mesaj);
