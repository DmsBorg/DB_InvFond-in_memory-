using BV212_EF.NET_ADO.DataBase;

public class InvestmentRow
{
    public int Id { get; }
    public int InvestorId { get; set; }
    public int StockId { get; set; }
    public int SharesCount { get; set; }
    public DateTime PurchaseDate { get; set; }

    private readonly PrimaryKey _primaryKey;

    public InvestmentRow()
    {
        _primaryKey = new PrimaryKey(typeof(InvestmentRow));
        Id = _primaryKey.Key;
    }
}
