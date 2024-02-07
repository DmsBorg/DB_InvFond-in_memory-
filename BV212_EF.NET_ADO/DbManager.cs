using BV212_EF.NET_ADO.DataBase;
using BV212_EF.NET_ADO.DataBase.Tables;
using System;

namespace BV212_EF.NET_ADO;

public class DbManager : IDisposable
{
    private const string HorizontalLine = "======================================";
    private InvestFondDB _database = new InvestFondDB();

    public void Run()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("Select an action:");
            Console.WriteLine("1 - Add Investor");
            Console.WriteLine("2 - Add Stock"); 
            Console.WriteLine("3 - Add Investment");
            Console.WriteLine("4 - Show Current Database State");
            Console.WriteLine("5 - Exit");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddInvestor();
                    break;
                case "2":
                    AddStock();
                    break;
                case "3":
                    AddInvestment();
                    break;
                case "4":
                    ShowCurrentDatabaseState();
                    break;
                case "5":
                    running = false;
                    ShowCurrentDatabaseState(); // Показать состояние базы данных перед выходом
                    break;
                default:
                    Console.WriteLine("Invalid choice, please select again.");
                    break;
            }
        }
    }

    private void AddInvestor()
    {
        Console.WriteLine("Enter Investor Name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter Investor Email:");
        string email = Console.ReadLine();

        var investor = new InvestorRow { Name = name, Email = email };
        _database.Investors.Add(investor);
        Console.WriteLine("Investor added successfully.");
    }

    private void AddInvestment()
    {
        Console.WriteLine("Enter Investor ID:");
        int investorId = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Stock ID:");
        int stockId = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Shares Count:");
        int sharesCount = int.Parse(Console.ReadLine());

        var investment = new InvestmentRow
        {
            InvestorId = investorId,
            StockId = stockId,
            SharesCount = sharesCount,
            PurchaseDate = DateTime.Now
        };
        _database.Investments.Add(investment);
        Console.WriteLine("Investment added successfully.");
    }

    private void AddStock()
    {
        Console.WriteLine("Enter Stock Symbol:");
        string symbol = Console.ReadLine();

        Console.WriteLine("Enter Stock Name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter Current Price:");
        double price = double.Parse(Console.ReadLine());

        var stock = new StockRow { Symbol = symbol, StockName = name, CurrentPrice = price };
        _database.Stocks.Add(stock);
        Console.WriteLine("Stock added successfully.");
    }

    private void ShowCurrentDatabaseState()
    {
        Console.WriteLine(HorizontalLine);
        Console.WriteLine("Current Database State:");
        Console.WriteLine("Investors:");
        foreach (var investor in _database.Investors)
        {
            Console.WriteLine($"ID: {investor.Id}, Name: {investor.Name}, Email: {investor.Email}");
        }

        Console.WriteLine("Investments:");
        foreach (var investment in _database.Investments)
        {
            Console.WriteLine($"ID: {investment.Id}, Investor ID: {investment.InvestorId}, Stock ID: {investment.StockId}, Shares: {investment.SharesCount}, Purchase Date: {investment.PurchaseDate}");
        }

        Console.WriteLine("Stocks:");
        foreach (var stock in _database.Stocks)
        {
            Console.WriteLine($"ID: {stock.Id}, Symbol: {stock.Symbol}, Name: {stock.StockName}, Price: {stock.CurrentPrice}");
        }
        Console.WriteLine(HorizontalLine);
    }

    public void Dispose()
    {
        
    }
}

