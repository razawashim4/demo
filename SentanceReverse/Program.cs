SentanseReverse();
void SentanseReverse()
{
    //Console.WriteLine("Enter yor sentance ");
    //string? sen = Console.ReadLine(), newSen = "";
    //var splitedStr = sen.Split(" ");
    //int i = splitedStr.Length - 1;
    //while (i >= 0)
    //{
    //    newSen += (" " + splitedStr[i]);
    //    i--;
    //}
    //Console.WriteLine(newSen);
    B b=new B();
    string s="This is my name";
    Console.WriteLine("Here is the s old value  ==>> " + s);
    //b.show();
    var newmane= b.GetName(out s, "Mansi");
    Console.WriteLine("Here is the s value  ==>> "+s);
    Console.WriteLine("Here is the New value  ==>> "+ newmane);
    //b.Disp();
    //b.Display();
    Console.ReadLine();
}
public interface X
{
    void Disp();
}
public abstract class Y: X
{
    public abstract void Display();
    public void Disp()
    {
        Console.WriteLine("Implemented Disp Method in Y Abstract Class ");
    }
}
public class A:Y,X
{
    sealed public override void Display()
    {
        Console.WriteLine("Class A Display MEthod called ");
    }
    //void X.Disp()
    //{
    //    Console.WriteLine("Class A DIsp MEthod called ");
    //}
    public virtual void show() 
    {
        Console.WriteLine("Main method");
    }
}
public class B :A 
{
    public override void show()
    {
        Console.WriteLine("Overriden method");
    }
    public string GetName(out string s, string name)
    {
        s = "Washim";
        return name+" Raza";
    }
}

public class S(string rr,int r)
{
    private readonly string q=rr;
    private readonly int w=r;
}