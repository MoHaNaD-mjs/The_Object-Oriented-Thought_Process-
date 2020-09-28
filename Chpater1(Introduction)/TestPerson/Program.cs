using System;

namespace The_Object_Oriented_Thought_Process_
{
    class Program
    {
        static void Main(string[] args)
        {
           Person joe =new Person();
           joe.Name="joe";
           Console.WriteLine(joe.Name);
           Console.ReadLine();
        }
    }
}

public class Person
{
    //Attributes
    private string strName;
    private string strAddress;
    
    //Methods
    public string Name
    {
        get{return strName;}
        set{ strName = value;}
    }
    public string Address
    {
        get{return strAddress;}
        set{strAddress=value;}
    }
}