using System.ComponentModel.DataAnnotations;

namespace AdminDBHandler.Models.User
{
    public interface IDiffUser
    {
        public string? ID { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public User? Individual { get; set; }
    }
}
