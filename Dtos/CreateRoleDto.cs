using System.ComponentModel.DataAnnotations;

namespace AuthAPI_903.Dtos
{
    public class CreateRoleDto
    {
        [Required(ErrorMessage = "Role Name is required.")]
        public string RoleName { get; set; } = null!;
    }
}
