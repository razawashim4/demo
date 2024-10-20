using ExtensionMethods;

methods();

void methods()
{
    string str = "washim raza";
    int ff= str.WordCount();
    Console.WriteLine(ff);
}
namespace ExtensionMethods
{
    public static class MyExtensions
    {
        public static int WordCount(this string str)
        {
            return str.Split(new char[] { ' ', '.', '?' },
                             StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}