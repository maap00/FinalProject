using FinalProject;



class Program
{
    static void Main(string[] args)
    {

        string name = Console.ReadLine();
        string lastName = Console.ReadLine();
        string userName = Console.ReadLine();
        string password = Console.ReadLine();
        string email = Console.ReadLine();

        User user = new User();
        User user2 = new User(1,name, lastName, userName, password, email);

        //Product product = new Product("P001", "PAPEL A4", 100, 150,1000,"maap00");



        user2.showDates();

       // product.showDates();
        
 
    }
}







