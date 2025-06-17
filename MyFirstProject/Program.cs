// Burası bir yorum satırıdır...


using System.Globalization;

string ad = "Ahmet";  //değişken tanımlaması string
var soyad = "Güvendik"; //var değişken türü otomatik olarak yazılan değerin türünü bilir ve onu alır
string message = "Patika sayesinde eksiklerimi kapatacağıma ve sektöre atılacağıma inandığım için buradayım";

Console.WriteLine(ad + " " + soyad);  //değişkenleri burada string türünde birleştirerek yazıyoruz.
Console.WriteLine(message);

string number = "42";
int result = 0;

int.TryParse(number, out result);
Console.WriteLine(result);

double sayi = 3.14;

int sayi2;

