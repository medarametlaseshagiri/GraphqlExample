using System.ComponentModel.DataAnnotations;

namespace GraphQLSample.Model
{
    public class Project
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Please specify a name for the project")]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
