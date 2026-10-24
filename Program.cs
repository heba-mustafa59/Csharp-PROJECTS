using System.Collections;
using System.Linq.Expressions;
using Abstraction;
public class Program
{
    public static void Main(string[] args)
    {
        ArrayList list = new ArrayList();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add("A");
        list.Add(new Dog());
      //  list.Add(new Duck());

        list.Remove(3);
        // System.Console.WriteLine(list.IndexOf(44));
        
        // foreach(int num in list){  
        //     System.Console.WriteLine(num);    
        // }

        // for(int i =0 ; i < list.Count; i++)
        // {
        //     if ( list[i] is Iswimanimal)
        //     {
        //        ((Iswimanimal)list[i]).swim();
        //     }
        //     Console.WriteLine(list[i]);
            
        // }



        ///////////////////
        
        // Hashtable ht = new Hashtable();
        // ht.Add(1, new Dog());
        // //ht.Add(2, new Duck());

        //  System.Console.WriteLine(ht.Contains(1));
        //   if ( ht[2] is Iswimanimal)
        //     {
        //        ((Iswimanimal)list[2]).swim();
        //     }
           
        // }

        List<int> list1 = new List<int>();
        List<Dog> list3 = new List<Dog>();
        List<Duck> list4 = new List<Duck>();
        list4.Add(new Duck("first"));  
        list4.Add(new Duck("second")); 

        foreach (Duck d in list4)
        {
            d.swim();
        } 

        for ( int i = 0 ; i< list4.Count; i++)
        {
            list4[i].swim();
        }

        Dictionary <String,Dog> hash = new Dictionary<string, Dog>();
        hash.Add("F",new Dog(){Name= "F", age= 3});
        hash.Add("A",new Dog(){Name = "A",age=5});
        System.Console.WriteLine(hash.GetValueOrDefault("F").age);
 

        HashSet<string> set = new HashSet<string>();
        set.Add("F");
        set.Add("A");
        System.Console.WriteLine(set.Contains("F"));
        {
        }


    }
        


}