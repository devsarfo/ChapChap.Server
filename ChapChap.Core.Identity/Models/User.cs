namespace ChapChap.Core.Identity.Models;

public class User
{
    protected User()
    {
        this.Uuid = Guid.NewGuid().ToString();
        this.CreatedAt = DateTime.UtcNow;
    }

    public User(string firstName, string lastName, string email, string phone, string password) : this()
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Name = $"{firstName} {lastName}";
        this.Password = password;
        this.Email = email;
        this.Phone = phone;
    }
    
    public int Id { get; }
    public string Uuid { get; }
    public string Name { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public DateTime? EmailVerifiedAt { get; set; }
    public string? Phone { get; set; }
    public DateTime? PhoneVerifiedAt { get; set; }
    public string Gender { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public string Password { get; set; }
    public string Country { get; set; }
    public string Currency { get; set; }
    public int Active { get; set; }
    public DateTime CreatedAt { get; }
    public DateTime? UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
}