using System.ComponentModel.DataAnnotations;

namespace IT15_HRMS.Models
{
    public class Info  // Class definition should be here
    {
        [Key] // Specifies that this is the Primary Key
        public int Id { get; set; }

        [MaxLength(40)]
        public string LN { get; set; } = " ";

        [MaxLength(50)]
        public string FN { get; set; } = " ";

        [MaxLength(50)]
        public string MD { get; set; } = " ";

        [MaxLength(2)]
        public int Age { get; set; }
    }
}

