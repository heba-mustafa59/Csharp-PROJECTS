namespace Abstraction;

public class Duck:Animal,Iswimanimal
{
 public override void makesound ()
    {
     Console.WriteLine(("Duck make sound"));
    } 
  public void swim()
    {
        System.Console.WriteLine("i am swimming");
    }
  public void Eat()
    {
        System.Console.WriteLine("i am eating ");
        
    }
}
