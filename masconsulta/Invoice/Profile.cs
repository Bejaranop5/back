namespace masconsulta.Invoice;

public partial class Profile
{
    public int ProfileId { get; set; }

    public string? ProfileName { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}