//integer veri tipi -2.147.483.648 ile bunun
//pozitif değeri arasında değer alır
//byte değişkeni 0-255 arasında değer alıyormuş
//sbyte değişkeni -128 - 127 arasında değer alıyormuş
//int a = 5;
//char letter = 'a';
//string name = "Çağrı Uğurel";
//byte number = 100;
//sbyte numbersByte = -100;
//bool isOkey = true;
//float fNumber = 64.231321f;

string name=String.Empty;
string surname = String.Empty;
int age;
Console.WriteLine("Lütfen isminizi giriniz: ");
name = Console.ReadLine();
Console.WriteLine("İsminiz: " + name);


Console.WriteLine("Lütfen soy isminizi giriniz: ");
surname = Console.ReadLine();
Console.WriteLine("Soy isminiz: " + surname);

Console.WriteLine("Yaşınızı giriniz: ");
age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Yaşınız: " + age);