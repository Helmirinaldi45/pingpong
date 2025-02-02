using System.ComponentModel.DataAnnotations;

namespace pingpong.Models
{
    public class Game
    {
        public int Id { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime GameDate { get; set; }
        public double? Score { get; set; }
        public string? HomeTeam { get; set; }
        public string? AwayTeam { get; set; }
        public string? winner {get; set;}
        public string? losser {get; set;}
    }
}
