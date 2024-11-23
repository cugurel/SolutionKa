List<string> students = new List<string>();

students.Add("Enes");
students.Add("Çağrı");
students.Add("Muhammed");
students.Add("Ertan");
students.Add("Efe");
students.Add("Şahin");

foreach (var student in students)
{
    Console.WriteLine(student);
}
Console.WriteLine("İsim çıkarıldıktan sonra");
students.Remove("Çağrı");
foreach (var student in students)
{
    Console.WriteLine(student);
}