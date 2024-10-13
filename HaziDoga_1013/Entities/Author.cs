using Microsoft.AspNetCore.Identity;

namespace HaziDoga_1013.Entities
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string UserId { get; set; }

        public IdentityUser User { get; set; }
    }

}
