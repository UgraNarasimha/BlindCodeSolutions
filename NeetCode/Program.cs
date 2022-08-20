using NeetCode;

Console.WriteLine("Hello, Ridhit!");

Car a = new Car();

a.honk();

Console.WriteLine(1 + 1);
Test x = new Test();

Console.WriteLine("Leetcode 3");
int[] b = { 1, 2, 3, 4 };
bool ans=x.ContainsDuplicate(b);
Console.WriteLine(ans);

Console.WriteLine("Leetcode 4");
var result4 = x.ProductExceptSelf(b);

foreach (int i in result4)
    Console.WriteLine(i);