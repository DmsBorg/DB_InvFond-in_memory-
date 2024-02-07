using BV212_EF.NET_ADO.DataBase.Tables;

namespace BV212_EF.NET_ADO.DataBase;

public class InvestFondDB
{
    public List<InvestorRow> Investors { get; set; }
    public List<InvestmentRow> Investments { get; set; }
    public List<StockRow> Stocks { get; set; }

    public InvestFondDB()
    {
        Investors = new List<InvestorRow>();
        Investments = new List<InvestmentRow>();
        Stocks = new List<StockRow>();
    }
}
