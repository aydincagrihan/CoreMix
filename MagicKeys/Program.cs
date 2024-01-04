//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//int minVal = int.MinValue;
//int maxVal = int.MaxValue;
////overflow hatası vermesin diye default olarak false oluyor ve min >max max>min oluyor
//minVal--;
//maxVal++;

//Console.WriteLine($"Min integer deger:{minVal}, Max Integer deger:{maxVal}");


using MagicKeys;

//var student=new Student();
//Console.WriteLine(student);

//Object Initalizer 
var numbers = new List<int>()
{
    {1},
    {2},
    {3}

};
numbers.Add(4);
foreach (var number in numbers)
{
    Console.WriteLine(number);
}

