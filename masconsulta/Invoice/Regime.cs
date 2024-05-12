namespace masconsulta.Invoice;

public partial class Regime
{
    public int RegimeId { get; set; }

    public string? RegimeName { get; set; }

    public virtual ICollection<Supplier> Suppliers { get; set; } = new List<Supplier>();
}