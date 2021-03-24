using Core.Entities.Abstract;

namespace BackendProject.Entities.DTOs
{
    public class UserForLoginDto:IDto
    {

        public string Email { get; set; }
        public string Password { get; set; }
    }
}
