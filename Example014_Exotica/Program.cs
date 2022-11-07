// 1. Случай, когда не известен наперед тип данных
// int a = 12;
using System.Linq;

// var a = 12; //сам определил тип данных через var
// Console.WriteLine(a.GetType());

var data = new int[] { 1, 2, 3, 4 }
         .Where(e => e > 0)
         .Select(e => new { q = e, w = e + 1 });
Console.WriteLine(data.GetType().Name);
// 