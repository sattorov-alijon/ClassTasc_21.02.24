Person person = new Person();
System.Console.Write("Enter your firstname: ");
person.FirstName = Console.ReadLine();
System.Console.Write("Enter your LastName : ");
person.LastName = Console.ReadLine();
System.Console.Write("Enter your Age : ");
person.Age = Convert.ToInt32(Console.ReadLine());

person.GetInfo();



// naqsha
public class Person
{
    public string FirstName; 
    public string LastName;
    public int Age;

    public void GetInfo()
    {
        System.Console.WriteLine($"FirstName: {FirstName} ");
        System.Console.WriteLine($"LastName: {LastName} ");
        System.Console.WriteLine($"Age: {Age}");
   }
}