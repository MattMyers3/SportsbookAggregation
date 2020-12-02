using System.ComponentModel.DataAnnotations;

namespace SportsbookAggregation.UserSettingsInfo.Models
{
    public class UserSettings
    {
        [Key]
        public string UserId { get; set; }

        public string[] DefaultBooks { get; set; }
    }
}