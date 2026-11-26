namespace LibraryManagementSystem.Api.Models;

public class Member
{
    public int Id { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public DateOnly MembershipDate { get; set; }

    public ICollection<Loan> Loans { get; set; } = new List<Loan>();
}
