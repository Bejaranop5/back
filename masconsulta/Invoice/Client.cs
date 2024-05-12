namespace masconsulta.Invoice;

public partial class Client
{
    public int ClientId { get; set; }

    public string? ClientName { get; set; }

    public int? CountryId { get; set; }

    public int? DepartmentId { get; set; }

    public int? CityId { get; set; }

    public string? Address { get; set; }

    public string? BusinessName { get; set; }

    public string? Nit { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public int? UserId { get; set; }

    public bool? IsActive { get; set; }

    public virtual City? City { get; set; }

    public virtual Country? Country { get; set; }

    public virtual Department? Department { get; set; }

    public virtual User? User { get; set; }
}