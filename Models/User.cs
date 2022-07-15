namespace Models;

public class User
{
    public Guid UserId { get; set; }
    public string UserName { get; set; }
    public Guid RoleId { get; set; }
    public DateTime CreateOn { get; set; }
    public DateTime ModifyOn { get; set; }
}