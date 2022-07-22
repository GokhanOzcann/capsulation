namespace capsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName, userPassword;
            Capsulation dbManager = new Capsulation();
            Console.WriteLine("{0}\n< C# Kapsülleme Örnekleri #1 >\n{1}");
            Console.Write("-> İsminizi Girin: ");
            dbManager.setLoginName = Console.ReadLine();
            Console.Write("{0}\n-> Lütfen veritabanı kullanıcı adını girin: ");
            userName = Console.ReadLine();
            Console.Write("-> Lütfen veritabanı kullanıcı şifresini girin: ");
            userPassword = Console.ReadLine();
            if (dbManager.checkName == userName && dbManager.checkPassword == userPassword)
            {
                dbManager.dbLogin();
            }
            else
                Console.WriteLine("{0}\n-> Giriş gerçekleştirilemedi.\n{1}");

        }
    }
}