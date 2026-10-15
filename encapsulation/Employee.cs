namespace encapsulation;

public class Employee
{
// fields or properties
public int Id {get;set;}
private string _FirstName { set;get;} 
private string _LastName { set;get;}
private double _salary{get;set;} 
public readonly string CompanyName;
public const double Tax = 0.1;
public  static int EmployeeCount = 0;
 
//Acces modifiers
// public, private, protected, internal, protected internal, private protected
// readonly, const, static, virtual, abstract, sealed, override, new
// Default constructor


public Employee()
    {
        Id = 0;
        _FirstName = "Default";
        _LastName = "Default";
        _salary = 0.0;
        EmployeeCount++;
        
    }
// Parameterized constructor
public Employee(int _id, string _firstName, string _lastName, double _salary)
    {
       Id = _id;
       _FirstName = _firstName;
       _LastName = _lastName;
       this._salary = _salary;
       EmployeeCount++;
    }
    private int age;

public int GetAge()
    {
        return age;

    }
public void SetAge(int value)
    {
        if (value > 0)
        age = value;
    }
private string department;
public string Department
    {
        get => department;
        set
        {
            if (value.Length > 0)
                department = value;
        }
    }
// Copy constructor 
public Employee(Employee emp)
    {
        Id = emp.Id;
        _FirstName = emp._FirstName;
        _LastName = emp._LastName;
        _salary = emp._salary;
        EmployeeCount++;

    }
    // Distructor
    ~Employee()
    {
     // do anything   
    }

// Private constructor 
    public  double getSalary()
    {
        return _salary - (_salary * Tax);
    }
    public void setSalary(double salary)
    {
        if (salary >0)
        _salary = salary;
    }

    public double Salary {
        get{return _salary - (_salary * Tax);}
        set{  if (value >0)
        _salary = value;}
        }

    public string FirstName {
        get=> _FirstName;
        set{
            if ( value.Length>0)
            _FirstName = value;
        }
    }
    public string LastName
    {
        get=> _LastName;
        set{
            if ( value.Length>0)
            _LastName = value;
        }
    }
    // static and non-static methods 
    public double CalculateSalary()
    {
        return Salary - (Salary-Tax);
    }
    public static int CountOddNumbers(int[] numbers)
    {
        int count = 0; 
        foreach (int number in numbers)
        {
            if (number % 2 != 0)
            count++;
        }
        return count;
    }
public string PrintEMployee()
    {
        return "id=" + Id + " name=" + _FirstName + " " + _LastName + " salary=" + _salary;
    } 

}
