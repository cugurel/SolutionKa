//Girilen sayının pozitif, nagatif ve ya sıfıra eşit ise yazdırır

//int a;
//Console.WriteLine("Bir sayı giriniz");
//a = Convert.ToInt32(Console.ReadLine());

//if(a < 0)
//{
//    Console.WriteLine("Sayı negatif");
//}else if(a == 0)
//{
//    Console.WriteLine("Sayı 0'a eşit");
//}
//else
//{
//    Console.WriteLine("Sayı pozitif");
//}

//Girilen inputa haftanın gününü yazar

int a;
Console.WriteLine("0-7 arasında sayı girin");
a = Convert.ToInt32(Console.ReadLine());

switch (a)
{
	case 1:
		Console.WriteLine("Pazartesi");
		break;
    case 2:
        Console.WriteLine("Salı");
        break;
    case 3:
        Console.WriteLine("Çarşamba");
        break;
    default:
        Console.WriteLine("Şart sağlanmadı");
		break;
}