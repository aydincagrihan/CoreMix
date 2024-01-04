// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int minVal = int.MinValue;
int maxVal = int.MaxValue;
//overflow hatası vermesin diye default olarak false oluyor ve min >max max>min oluyor
minVal--;
maxVal++;

Console.WriteLine($"Min integer deger:{minVal}, Max Integer deger:{maxVal}");