
using Prototype;

Console.WriteLine("Hello, World!");
Virus virus1 = new Virus(1.2, 3, "Virus1", "SomeSpec1", new List<VirusChild> { });
Virus virus2 = new Virus(0.8, 1, "Virus2", "Spec2", new List<VirusChild> { new VirusChild(new DateTime(2023, 12, 1), virus1) });
Virus virus3 = new Virus(0.5, 2, "Virus3", "Spec3", new List<VirusChild> { new VirusChild(new DateTime(2022, 12, 6), virus2), new VirusChild(new DateTime(2023, 12, 11), virus2) });


Virus virus4 = (Virus)virus1.Clone();
Virus virus5 = (Virus)virus2.Clone();
Virus virus6 = (Virus)virus3.Clone();

//перевірка на правильність клонування
Console.WriteLine(virus4 == virus1);
Console.WriteLine(virus6== virus2);

//репрезентація глубинного копіювання (навіть чайлд віруси клонуються та використовуються як клони)
VirusChild child = virus5.Children[0];
child.BirthDate = new DateTime(2021, 1, 1);
Console.WriteLine($"virus2.Children[0].BirthDate: {virus2.Children[0].BirthDate}"); 
Console.WriteLine($"virus5.Children[0].BirthDate: {virus5.Children[0].BirthDate}");