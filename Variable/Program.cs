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


//Kullanıcıdan giriş alma
//string name=String.Empty;
//string surname = String.Empty;
//int age;
//Console.WriteLine("Lütfen isminizi giriniz: ");
//name = Console.ReadLine();
//Console.WriteLine("İsminiz: " + name);


//Console.WriteLine("Lütfen soy isminizi giriniz: ");
//surname = Console.ReadLine();
//Console.WriteLine("Soy isminiz: " + surname);

//Console.WriteLine("Yaşınızı giriniz: ");
//age = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Yaşınız: " + age);

//Kullanıcının girdiği iki sayının ortalamasını alma
int a, b, sum, avg;
Console.WriteLine("İlk sayıyı giriniz: ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("İkinci sayıyı giriniz: ");
b = Convert.ToInt32(Console.ReadLine());
sum = a + b;
avg = sum / 2;
Console.WriteLine("İki sayının ortalaması : " + avg);

int mod = avg % 2;
if (mod == 1)
{
    Console.Write("Ortalama tek");
}
else
{
    Console.Write("Ortalama çift");
}

//Girilen sayının tek mi çift mi karar veren yazılım
//int number;
//Console.WriteLine("Sayı giriniz: ");
//number =  Convert.ToInt32(Console.ReadLine());

//int mod = number % 2;

//if(mod == 0)
//{
//    Console.WriteLine("Girilen sayı çifttir");
//}
//else
//{
//    Console.WriteLine("Girilen sayı tektir");
//}