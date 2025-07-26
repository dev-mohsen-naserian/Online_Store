namespace OnlineStore.BlazorUI.Models;
/// <summary>
/// Role Fore Users
/// </summary>
 public class Roles
 {
    public  Roles()
    {
        IsDeleted = false;
    }
    /// <summary>
    /// Id For find title role
    /// </summary>
    public int RoleId { get; set; }
    /// <summary>
    /// Title Role for user
    /// </summary>
    public string RoleName { get; set; }
    /// <summary>
    /// Delete Role
    /// </summary>
    public bool IsDeleted { get; set; }
}

