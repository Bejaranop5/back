namespace masconsulta.Invoice;

public partial class Department
{
    public int DepartmentId { get; set; }

    public string? DepartmentName { get; set; }

    public int? CountryId { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<City> Cities { get; set; } = new List<City>();

    public virtual ICollection<Client> Clients { get; set; } = new List<Client>();

    public virtual Country? Country { get; set; }

    public virtual ICollection<Supplier> Suppliers { get; set; } = new List<Supplier>();
}