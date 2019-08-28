
using Microsoft.AspNetCore.Http;

namespace OrderTracker.CreateViewModel
{
    public class CreateViewModel
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public IFormFile Photo { get; set; }
    }

}
