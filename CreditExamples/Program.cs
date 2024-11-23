List<string> credits = new List<string>();
credits.Add("Garanti Bankası");
credits.Add("Odeabank");
credits.Add("Yapı Kredi");

Console.WriteLine("Kredi işlemi yapabileceğiz bankalar: ");
foreach (var item in credits)
{
    Console.WriteLine(item);
}

int credit;
int option;
Console.WriteLine("Çekmek istediğiniz kredi miktarını giriniz:");
credit = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Banka seçiniz:");
option = Convert.ToInt32(Console.ReadLine());
int sum;
if(option == 1)
{
    credit = credit + 300;
}
if (option == 2)
{
    credit = credit + 500;
}
if (option == 3)
{
    credit = credit + 1000;
}

Console.WriteLine("Geri ödemeli tutar = " + credit);   