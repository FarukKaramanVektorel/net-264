// Language Integrated Query => LINQ

// LINQ to Object


using Linq;

List<int> sayilar = new List<int> { 97, 81, 127, 692, 15, 4789, 30, -92, -191, 71 };
List<int> tekSayilar = new List<int>();

foreach (int i in sayilar)
{
    if (!(i % 2 == 0)) tekSayilar.Add(i);
}
Console.WriteLine(string.Join(", ", tekSayilar));

var tekSayi = sayilar.Where(s => !(s % 2 == 0)).ToList();
Console.WriteLine(string.Join(", ", tekSayi));
var siraliPozitif = sayilar.Where(s => s > 0).OrderBy(s => s).ToList();
var siraliPozitifQ = (from s in sayilar
                      where s > 0
                      orderby s
                      select s
                      ).ToList();

Console.WriteLine(string.Join(", ", siraliPozitif));
Console.WriteLine(string.Join(", ", siraliPozitifQ));

List<Product> products = new List<Product>{
new Product("Klavye",1764.99,"OEM"),
new Product("Mause",1264.99,"OEM"),
new Product("Masa",2764.99,"Aksesuar"),
new Product("Sandalye",1964.99,"Aksesuar"),
new Product("Yazıcı",1864.99,"OEM"),
new Product("Nvdia 4060",1564.99,"Donanım")
};

var pahaliUrunler=products.Where(p=>p.Price>1900).OrderBy(p=>p.Price).ToList();
var siraliUrunler=products.Where(p => p.Price > 1900).Select(s=>s.Name).OrderBy(s=>s).ToList();
Console.WriteLine(string.Join(", ", pahaliUrunler));
Console.WriteLine(string.Join(", ", siraliUrunler));





