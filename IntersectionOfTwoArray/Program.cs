// See https://aka.ms/new-console-template for more information
Console.WriteLine("HWe are finding the Intersection of int Array");

FindIntersectioOfTwoIntArray();
void FindIntersectioOfTwoIntArray()
{
    Console.WriteLine("Enter your First Int array ");
    int[] a = [1, 2, 3, 4, 5];
    int[] b = [1, 2, 4, 7, 8, 9];
    var c=a.Intersect(b);
    Console.WriteLine(string.Join(",",c));
}
