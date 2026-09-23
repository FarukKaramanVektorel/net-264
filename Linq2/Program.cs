using Linq2;



//List<int> list = new List<int> { 1, 2, 3, 4, 5 };

//var query = list.Where(s => s > 2);

//list.Add(10); 
//list.Add(20);

//var query2=list.Where(s => s > 3).ToList();
//list.Add(75);

//Console.WriteLine(string.Join(", ",query2 ));
//Console.WriteLine(string.Join(", ",query ));




List<Customer> customers = new List<Customer>
            {
                new Customer(1, "Ahmet Yılmaz"),
                new Customer(2, "Ayşe Demir"),
                new Customer(3, "Mehmet Kaya"),
                new Customer(4, "Fatma Çelik"),
                new Customer(5, "Can Şahin"),
                new Customer(6, "Zeynep Aydın"),
                new Customer(7, "Murat Öztürk"),
                new Customer(8, "Elif Koç"),
                new Customer(9, "Burak Arslan"),
                new Customer(10, "Sibel Yıldız")
            };

var result = CustomerSearch("Sibel Yıldız", 0);

Console.WriteLine(string.Join(", ",result ));
Console.WriteLine(string.Join(", ", CustomerSearch(null, 2)));
List<Customer> CustomerSearch(string name,int id){
    IEnumerable<Customer> query = customers;
    if (!string.IsNullOrEmpty(name))
    {
        query=query.Where(x => x.Name == name);
    }

    if (id > 0) {

        query=query.Where(x=>x.Id== id);

    }

    return query.ToList();
}

//// 2. Ürünler Listesi (50 Ürün)
//List<Product> products = new List<Product>
//            {
//                // Elektronik (10 adet)
//                new Product(1, "Laptop Pro X1", "Elektronik", 24500.0),
//                new Product(2, "Kablosuz Kulaklık", "Elektronik", 1250.0),
//                new Product(3, "Akıllı Saat", "Elektronik", 3400.0),
//                new Product(4, "Bluetooth Hoparlör", "Elektronik", 850.0),
//                new Product(5, "Oyuncu Klavyesi", "Elektronik", 1450.0),
//                new Product(6, "Optik Mouse", "Elektronik", 450.0),
//                new Product(7, "27 inç Monitör", "Elektronik", 6200.0),
//                new Product(8, "1TB Taşınabilir SSD", "Elektronik", 2800.0),
//                new Product(9, "Type-C Hızlı Şarj Cihazı", "Elektronik", 350.0),
//                new Product(10, "Akıllı Telefon Standı", "Elektronik", 150.0),

//                // Giyim (10 adet)
//                new Product(11, "Slim Fit Kot Pantolon", "Giyim", 750.0),
//                new Product(12, "Pamuklu Basic Tişört", "Giyim", 250.0),
//                new Product(13, "Kapüşonlu Sweatshirt", "Giyim", 950.0),
//                new Product(14, "Deri Mont", "Giyim", 4200.0),
//                new Product(15, "Kışlık Mont", "Giyim", 2100.0),
//                new Product(16, "Spor Ayakkabı", "Giyim", 1850.0),
//                new Product(17, "Klasik Kumaş Pantolon", "Giyim", 850.0),
//                new Product(18, "Çizgili Gömlek", "Giyim", 550.0),
//                new Product(19, "Yün Atkı", "Giyim", 200.0),
//                new Product(20, "Termal İçlik Takımı", "Giyim", 650.0),

//                // Ev & Yaşam (10 adet)
//                new Product(21, "Granit Tencere Seti", "Ev & Yaşam", 3200.0),
//                new Product(22, "Çelik Kettle", "Ev & Yaşam", 750.0),
//                new Product(23, "Filtre Kahve Makinesi", "Ev & Yaşam", 1400.0),
//                new Product(24, "Robot Süpürge", "Ev & Yaşam", 9500.0),
//                new Product(25, "Yatak Örtüsü Takımı", "Ev & Yaşam", 1200.0),
//                new Product(26, "Porselen Yemek Takımı", "Ev & Yaşam", 2400.0),
//                new Product(27, "Bambu Kesme Tahtası", "Ev & Yaşam", 180.0),
//                new Product(28, "Masa Lambası", "Ev & Yaşam", 450.0),
//                new Product(29, "Banyo Paspas Seti", "Ev & Yaşam", 350.0),
//                new Product(30, "Kurutmalık", "Ev & Yaşam", 500.0),

//                // Kırtasiye & Kitap (10 adet)
//                new Product(31, "KİTAP: Suç ve Ceza", "Kırtasiye", 95.0),
//                new Product(32, "KİTAP: Sefiller", "Kırtasiye", 110.0),
//                new Product(33, "KİTAP: 1984", "Kırtasiye", 85.0),
//                new Product(34, "KİTAP: Simyacı", "Kırtasiye", 75.0),
//                new Product(35, "KİTAP: Nutuk", "Kırtasiye", 130.0),
//                new Product(36, "Ajanda 2026", "Kırtasiye", 220.0),
//                new Product(37, "Tükenmez Kalem Seti", "Kırtasiye", 120.0),
//                new Product(38, "Kurşun Kalem Kutusu", "Kırtasiye", 60.0),
//                new Product(39, "Yapışkanlı Not Kağıdı", "Kırtasiye", 45.0),
//                new Product(40, "Sırt Çantası", "Kırtasiye", 850.0),

//                // Spor & Outdoor (10 adet)
//                new Product(41, "Koşu Bandı", "Spor", 12500.0),
//                new Product(42, "Dambıl Seti (2x10kg)", "Spor", 1100.0),
//                new Product(43, "Yoga Matı", "Spor", 350.0),
//                new Product(44, "Pilates Topu", "Spor", 280.0),
//                new Product(45, "Futbol Topu", "Spor", 600.0),
//                new Product(46, "Basketbol Topu", "Spor", 750.0),
//                new Product(47, "Çadır (3 Kişilik)", "Spor", 2600.0),
//                new Product(48, "Matara / Su Matarası", "Spor", 320.0),
//                new Product(49, "Direnç Lastiği Seti", "Spor", 220.0),
//                new Product(50, "Kamp Sandalyesi", "Spor", 450.0)
//            };

//// 3. Siparişler Listesi (Müşteriler ve Ürünler Arasında İlişki - 30 Sipariş)
//List<Siparis> siparisler = new List<Siparis>
//            {
//                new Siparis(1, 1),   // Ahmet -> Laptop
//                new Siparis(1, 2),   // Ahmet -> Kulaklık
//                new Siparis(1, 31),  // Ahmet -> Suç ve Ceza
//                new Siparis(2, 11),  // Ayşe -> Kot Pantolon
//                new Siparis(2, 12),  // Ayşe -> Tişört
//                new Siparis(2, 21),  // Ayşe -> Tencere Seti
//                new Siparis(3, 24),  // Mehmet -> Robot Süpürge
//                new Siparis(3, 3),   // Mehmet -> Akıllı Saat
//                new Siparis(4, 41),  // Fatma -> Koşu Bandı
//                new Siparis(4, 43),  // Fatma -> Yoga Matı
//                new Siparis(5, 5),   // Can -> Oyuncu Klavyesi
//                new Siparis(5, 6),   // Can -> Mouse
//                new Siparis(5, 13),  // Can -> Sweatshirt
//                new Siparis(6, 23),  // Zeynep -> Kahve Makinesi
//                new Siparis(6, 25),  // Zeynep -> Yatak Örtüsü
//                new Siparis(7, 14),  // Murat -> Deri Mont
//                new Siparis(7, 16),  // Murat -> Spor Ayakkabı
//                new Siparis(8, 35),  // Elif -> Nutuk
//                new Siparis(8, 36),  // Elif -> Ajanda
//                new Siparis(8, 40),  // Elif -> Sırt Çantası
//                new Siparis(9, 47),  // Burak -> Çadır
//                new Siparis(9, 50),  // Burak -> Kamp Sandalyesi
//                new Siparis(10, 21), // Sibel -> Tencere Seti
//                new Siparis(10, 26), // Sibel -> Yemek Takımı
//                new Siparis(1, 7),   // Ahmet -> Monitör
//                new Siparis(3, 8),   // Mehmet -> SSD
//                new Siparis(4, 15),  // Fatma -> Kışlık Mont
//                new Siparis(6, 22),  // Zeynep -> Kettle
//                new Siparis(9, 45),  // Burak -> Futbol Topu
//                new Siparis(10, 31)  // Sibel -> Suç ve Ceza
//            };


//var musteriSiparisleri = customers
//    .Join(
//    siparisler, 
//    customer => customer.Id,
//    siparis => siparis.CustomerId,
//    (customer, siparis) => new { customer ,siparis })
//    .Join(
//    products,
//    cs=>cs.siparis.ProductId,
//    prod=>prod.Id,
//    (cs,prod) =>new {MusteriAdi=cs.customer.Name,UrunAdi=prod.Name, Fiyat=prod.Price}
//    )
//    .ToList();

//foreach (var item in musteriSiparisleri)
//{
//    Console.WriteLine($"{item.MusteriAdi} - {item.UrunAdi} - {item.Fiyat}");
//}





// Gruplama Metodları
//var kategoriler=products.GroupBy(p=>p.Category).ToList();

//foreach(var item in kategoriler)
//{
//    Console.WriteLine($"Kategori: {item.Key}");
//    foreach(var item2 in item)
//    {
//        Console.WriteLine($"     Ürün: {item2}");
//    }
//}

//var kategoriOzetleri = products
//    .GroupBy(p => p.Category)
//    .Select(c => new { Kategori = c.Key, ToplamFiyat = c.Sum(f => f.Price), UrunSayisi = c.Count() }).ToList();

//foreach (var item in kategoriOzetleri)
//{
//    Console.WriteLine($"Kategori Özetleri: {item.Kategori}, {item.UrunSayisi}, {item.ToplamFiyat}");
//}

//Eleman Seçme Metodları

//Product firstElktr = products.First(p => p.Category == "Elektronik");
////Product firstGida = products.First(p => p.Category == "Gıda");
////Product singleGida = products.Single(p => p.Category == "Gıda");
//Product singleDefaultGida = products.SingleOrDefault(p => p.Category == "Züccaciye");
//Product firstDefaultSpor = products.FirstOrDefault(p => p.Category == "Gıda");
//Console.WriteLine(firstElktr);
//Console.WriteLine(firstDefaultSpor);
////Console.WriteLine(singleGida);
//Console.WriteLine(singleDefaultGida);


// Toplama Özet Metodları
//int toplamUrun = products.Count;
//int sporUrunleriSayisi = products.Count(p => p.Category == "Spor");
//double toplamFiyat = products.Sum(p => p.Price);
//double toplamFiyatSpor = products.Where(p=>p.Category=="Spor").Sum(p => p.Price);

//int categorySize=products.Select(p=>p.Category).Distinct().Count();

//double ortFiyat = products.Average(p => p.Price);
//double enUcuz=products.Min(p => p.Price);
//double enPahali=products.Max(p=> p.Price);
//bool varmi = products.Any(p => p.Price > 20000);
//bool ucuzMu = products.All(p => p.Price < 100000);

//Console.WriteLine(string.Join(", ", products.GroupBy(p => p.Category).Select(c => $"{c.Key}: {c.Count()}")));
//Console.WriteLine($"Toplam Ürün Sayısı: {toplamUrun}, Spor Ürünleri Sayısı: {sporUrunleriSayisi}");
//Console.WriteLine($"Toplam Fiyat: {toplamFiyat} TL, Spor Ürünleri Fiyatı: {toplamFiyatSpor} TL");
//Console.WriteLine($"En Düşük Fiyat: {enUcuz} TL, En Yüksek Fiyat: {enPahali} TL");
//Console.WriteLine($"Toplam Kategori Sayısı: {categorySize}");
//Console.WriteLine($"Ortalama Fiyat: {ortFiyat}");
//Console.WriteLine($"Yüksek Fiyatlı Var Mı:  {varmi}");
//Console.WriteLine($"Ucuz Mu:  {ucuzMu}");
