namespace AutomatedTellerMachine.Controllers
{
    internal class Database
    {
        public string connectionString { get; set; }

        public Database()
        {
            /*
            connectionString = "Data Source=DESKTOP-CV57V7N\\SQLEXPRESS;Initial Catalog=SummerTimeBank;"
            + "Integrated Security=True";
            */

            connectionString = "Data Source=DESKTOP-T4TERMR\\SQLEXPRESS;Initial Catalog=SummerTimeBank;"
            + "Integrated Security=True";

        }
    }
}