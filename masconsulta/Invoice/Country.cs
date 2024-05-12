namespace masconsulta.Invoice;

public partial class Country
{
    public int CountryId { get; set; }

    public string? CountryName { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<Client> Clients { get; set; } = new List<Client>();

    public virtual ICollection<Department> Departments { get; set; } = new List<Department>();

    public virtual ICollection<Supplier> Suppliers { get; set; } = new List<Supplier>();
}