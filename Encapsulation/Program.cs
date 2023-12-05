using Encapsulation;

public class Program
{
    public static void Main()
    {
        miniProject Project = new miniProject("Computer fundamental","Salman muqtadir",69);
        miniProject Project1 = new miniProject("Algorithm","pritom hasan",000);
        Project.DisplayInfo();
        Project1.DisplayInfo();

        library nameofLibrary = new library("Bengal book");
        nameofLibrary.AddBook(Project);
        nameofLibrary.AddBook(Project1);
        nameofLibrary.DisplayInfo();
        Console.ReadKey();
    }
}