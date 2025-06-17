string TC;
string Name;
string Surname;
string PhoneNumber;
string Age;
string FistItem;
string SecondItem;

//Read ile işlem yapılacağından kaynaklı hepsi string olarak tanımlandı.

Console.WriteLine("Lütfen Aşağıdaki Bilgileri Giriniz:");
Console.WriteLine("Tc Kimlik No:");
TC = Console.ReadLine();
Console.WriteLine("Adınız:");
Name = Console.ReadLine();
Console.WriteLine("Soyadınız:");
Surname = Console.ReadLine();
Console.WriteLine("Telefon Numaranız:");
PhoneNumber = Console.ReadLine();
Console.WriteLine("Yaşınız:");
Age = Console.ReadLine(); 
Console.WriteLine("İlk Aldığınız Ürün Fiyatı:");
FistItem = Console.ReadLine();
Console.WriteLine("Son Aldığınız Ürün Fiyatı:");
SecondItem = Console.ReadLine();

//Yukarıda verileri ReadLine ile okuyup değişkenlere atama yapıyoruz.

Console.WriteLine($"{TC} Tc Numaralı {Name} {Surname} isimli kişi kayıt oluşturmuştur");
Console.WriteLine($"{PhoneNumber} telefon numarasına bildirim mesajı gönderilmiştir");

//Atadığımız verileri WriteLine ile ekranda gösteriyoruz.

int.TryParse(FistItem, out int resultFirstItem);
int.TryParse(SecondItem, out int resultSecondItem);

//string olarak aldığımız değerleri casting işlemiyle int yapıyooruz.

int toplamItem = resultFirstItem + resultSecondItem; //iki item'in toplamını alıyoruz
double discount = (toplamItem  * 10) / 100;   //toplam değerin yüzde 10'unu hesaplıyoruz.


Console.WriteLine($"{toplamItem} toplam harcama karşılığında kazanılan yüzde 10 patika puan miktarı --> {discount} TL'dir");
 


