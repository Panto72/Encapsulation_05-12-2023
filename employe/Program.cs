using employe;

public class Program
{
    public static void Main()
    {
        Employe employe = new Employe();
        string name =employe.Name = "Pranto";
        string title =employe.job_title = "junior developer";
        double salary =employe.setsalary(50000);
        Console.WriteLine(name);
        Console.WriteLine(title);
        Console.WriteLine(salary);
        employe.Promotion("senior developer");
        Employe employe1 = new Employe();
        string name2 = employe1.Name = "Surovi";
        string title2 = employe1.job_title = "junior developer";
        double salary2 = employe1.setsalary(30000);
        Console.WriteLine(name2);
        Console.WriteLine(title2);
        Console.WriteLine(salary2);
        employe1.Promotion("CEO");
        Console.ReadKey();
    }
}