using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BERYLLIUM.Models
{
    public class Work
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        [NotMapped, Required]
        public IFormFile Photo { get; set; }
    }
}
