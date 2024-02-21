var Employee1=new Employee();
Employee1.FirstName="Alijon";
Employee1.LastName="Sattorov";
Employee1.Age=22;
Employee1.Position="Programmer";
Employee1.Salary=50000;


System.Console.WriteLine(Employee1.GetInfo());
System.Console.WriteLine();

System.Console.Write("Set a new Salary: ");
Employee1.SetSalary(60000);
System.Console.WriteLine(Employee1.GetSalary());



System.Console.WriteLine();
System.Console.WriteLine(Employee1.GetInfo());





class Employee
{
    public string FirstName;
    public string LastName;
    public int Age;

    public string Position;
    public decimal Salary;

    public void SetSalary(decimal salary)
{
Salary=salary;
}
public decimal GetSalary()
{
return  Salary;
}

public string GetInfo()
{
    return$"FirstName: {FirstName} \nLastName: {LastName}\nAge: {Age}\nPosition: {Position}\nSalary: {Salary}";
}

}