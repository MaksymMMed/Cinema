using System.ComponentModel.DataAnnotations;
namespace Cinema.DAL.Enums;

public enum UserRolesEnum
{
    [Display(Name ="User")]
    User = 1,
    [Display(Name = "Admin")]
    Admin = 2,
    [Display(Name = "SuperAdmin")]
    SuperAdmin = 3,
}   