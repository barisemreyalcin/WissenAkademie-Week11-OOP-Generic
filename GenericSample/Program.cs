// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using GenericSample;

//NonGenericClass obj = new NonGenericClass();
//obj.Print(24);
//Console.ReadLine();
//obj.Print<int>(24);
//Console.ReadLine();
//obj.Print<int>((int)24.00);
//Console.ReadLine();
//obj.Print<string>("Hello, world!");
//Console.ReadLine();
//obj.Print("Hello, world!");
//Console.ReadLine();
////obj.Print<int>(int.Parse(false.ToString()));
//Console.ReadLine();

//GenericClass<int> student = new GenericClass<int>();
//student.ID = 10001;
//student.Name = "John";
//student.Surname = "Doe";
//Console.WriteLine(student.ToString());

//GenericClass<Guid> teacher = new GenericClass<Guid>();
////teacher.ID = 10001; // Derleme hatası
//teacher.ID = Guid.NewGuid();
//teacher.Name = "Jane";
//teacher.Surname = "Doe";
//Console.WriteLine(teacher.ToString());

//KeyValuePairClass<int, string> user = new KeyValuePairClass<int, string>();
//user.ID = 1;
//user.Name = "Harry Doe";
//user.BirthDate = new DateTime(1995, 11, 11);
//Console.WriteLine(user.ToString());

//KeyValuePairClass<Guid, string> user2 = new KeyValuePairClass<Guid, string>();
//user2.ID = Guid.NewGuid();
//user2.Name = "Larry Doe";
//user2.BirthDate = DateTime.Now.AddYears(-26);
//Console.WriteLine(user2.ToString());

//GenericField<int> field = new GenericField<int>();
//field.id = 81; // "81" olmaz
//Console.WriteLine($"Field: {field.id}");

GenericMethod<string> teams = new GenericMethod<string>();
teams.AddElement(0, "Galatasaray");
teams.AddElement(1, "Fenerbahçe");
teams.AddElement(2, "Beşiktaş");
teams.AddElement(3, "Trabzonspor");
teams.AddElement(4, "Başakşehir");

for (int i = 0; i < teams.arr.Length; i++)
{
    Console.WriteLine($"Index: {i} - Element: {teams.GetData(i)}");
}

Console.ReadLine();

GenericMethod<int> ages = new GenericMethod<int>();
Random rand = new Random();
for (int i = 0; i < 5; i++)
{
    ages.AddElement(i, rand.Next(1, 24));
}

for (int i = 0; i < ages.arr.Length; i++)
{
    Console.WriteLine($"Index: {i} - Element: {ages.GetData(i)}");
}