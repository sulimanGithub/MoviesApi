using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MoviesApi.Models
{
    public class Genre
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] /*Becuse it is byte */
        public byte Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }
    }
}
