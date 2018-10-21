namespace Extensibility
{
    class Program
    {

        // OCP - Open closed principle
        // Open for extension, but closed for modification

        // DBMigration is closed for modification, but open to extension via interface !
        static void Main(string[] args)
        {


            var migrator = new DBMigrator(new FileLogger("C:\\Users\\Roman\\Documents\\Programmierung\\VS\\Udemy\\CSharpIntermediate\\Tutorials\\Udemy.Intermediate.Tutorials\\log.txt"));

            migrator.Migrate();

        }
    }
}
