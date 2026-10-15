using System;
using encapsulation;

class Program
{ 
    static void Main(string[] args){
    Employee emp1 = new Employee(2 ,"samir","khan",3000);
   
    Employee emp2 = new Employee(1,"John","Doe",50000);
     emp1.SetAge(-1);
    Console.WriteLine("Age set using setter: " + emp1.GetAge());
    //using setters and getters
    emp1.Department = "HR";
    Console.WriteLine("Department set using expression-bodied property: " + emp1.Department);
    Console.WriteLine(emp1.CalculateSalary());
    Console.WriteLine(emp2.CalculateSalary());


     
} }