

/*
 Struct-Value Type-
Class-Reference Type

Notlar:degişken>Stackte tutulur. Heapte:degerleri tutulur
 */
using System.Diagnostics;
using System.Text;
//Struct-Value Type

//int i = 1;
//int j = i;
//i = 10;
//Console.WriteLine($"i:{i},j:{j}");//i=10 j=1 sonucu alırız bu value typeler için atama yapar yapmaz direkt kopyalanır. son değerini görmez

//#if DEBUG
////Debug.WriteLine("Bu sadece DEBUG modunda görünecek!");
////Trace.WriteLine(j);

//#endif

////Class Reference Type
////Test t=new Test();
////t.Id = 5;

////Test t1 = t;
////t.Id = 10;
////Console.WriteLine($"t.id :{t.Id}  t1.id :{t1.Id}");// t.id=10 t1.id=10 oldu referance tipte en son ne atandıysa onu kullanan yerlerde değişir. 


//int counter = 100000;
//Stopwatch sw = Stopwatch.StartNew();

//StringBuilder sb = new StringBuilder();

//for (int i = 1; i < counter; i++)
//{
//  sb.Append(i.ToString());
//}
//sw.Stop();
//long stringBuilderMS = sw.ElapsedMilliseconds;

//sw.Restart();


//String test = "";

//for (int i = 1; i < counter; i++)
//{
//    test += i.ToString();
//}
//sw.Stop();

//Console.WriteLine("Total: MS for StringBuilder :\t" + stringBuilderMS);//Referance tip çok daha hızlı StringBuilder
//Console.WriteLine("Total: MS for String :\t" + sw.ElapsedMilliseconds);//Value type

///* String vs StringBuilder
// * string: String nesneleri üzerinde yapılan işlemler, yeni nesneler oluşturarak gerçekleştiği için performans açısından maliyetlidir.
//StringBuilder: StringBuilder, bir dize üzerinde değişiklik yaparken orijinal nesneyi değiştirir, bu da performans açısından daha verimli bir yaklaşım sunar, özellikle büyük metin verileri üzerinde çalışırken.
// */



//public class Test
//{
//    public int Id { get; set; }
//}






