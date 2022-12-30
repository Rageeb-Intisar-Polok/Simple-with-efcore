using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace AdminDBHandler.Models.User
{
    public class User
    {
        [Key]
        public string? UUId { get; set; }
        public int Number_of_connections { get; set; }
        public JsonDocument ConnectionList { get; set; }
    }
}
