namespace BV212_EF.NET_ADO.DataBase.Tables;

public class InvestorRow
{
    public int Id { get; }
    public string Name { get; set; }
    public string Email { get; set; }

    private readonly PrimaryKey _primaryKey;

    public InvestorRow()
    {
        _primaryKey = new PrimaryKey(typeof(InvestorRow));
        Id = _primaryKey.Key;
    }
}