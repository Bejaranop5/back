namespace masconsulta.Invoice;

public partial class User
{
    public int UserId { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public int? PerfilId { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<Client> Clients { get; set; } = new List<Client>();

    public virtual Profile? Perfil { get; set; }
}