using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Users;

[Table("Users")]
public class UserEntity(
    int id,
    string firstName,
    string lastName,
    string email,
    string password,
    int role)
{
    [Key]
    public int Id { get; set; } = id;

    [Required]
    [MaxLength(64)]
    public string FirstName { get; set; } = firstName;

    [Required]
    [MaxLength(64)]
    public string LastName { get; set; } = lastName;

    [Required]
    [MaxLength(64)]
    public string Email { get; set; } = email;

    [Required]
    [MaxLength(256)]
    public string Password { get; set; } = password;

    [Required]
    public int Role { get; set; } = role;
}