using BV212_EF.NET_ADO;

    Console.WriteLine("The Investment Fund Database Management System\n");
    using (var dbManager = new DbManager())
    {
        dbManager.Run();
    }

