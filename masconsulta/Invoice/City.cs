namespace masconsulta.Invoice;

public partial class City
{
    public int CityId { get; set; }

    public string? CityName { get; set; }

    public int? DepartmentId { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<Client> Clients { get; set; } = new List<Client>();

    public virtual Department? Department { get; set; }

    public virtual ICollection<Supplier> Suppliers { get; set; } = new List<Supplier>();
}