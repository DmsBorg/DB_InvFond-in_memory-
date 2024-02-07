using BV212_EF.NET_ADO.DataBase;

public class StockRow
{
    public int Id { get; }
    public string Symbol { get; set; }
    public string StockName { get; set; }
    public double CurrentPrice { get; set; }

    private readonly PrimaryKey _primaryKey;

    public StockRow()
    {
        _primaryKey = new PrimaryKey(typeof(StockRow));
        Id = _primaryKey.Key;
    }
}