using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models
{
    [Table("Post")]
    public class Post
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(160)]
        [Column("Title", TypeName = "VARCHAR")]
        public string? Title { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(255)]
        [Column("Summary", TypeName = "VARCHAR")]
        public string? Summary { get; set; }

        [Required]
        [Column("Body", TypeName = "TEXT")]
        public string? Body { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(80)]
        [Column("Slug", TypeName = "VARCHAR")]
        public string? Slug { get; set; }

        [DataType(DataType.Date)]
        [Column("CreateDate", TypeName = "DATETIME")]
        public DateTime CreateDate { get; set; }

        [DataType(DataType.Date)]
        [Column("LastUpdateDate", TypeName = "DATETIME")]
        public DateTime LastUpdateDate { get; set; }

        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        [ForeignKey("AuthorId")]
        public int AuthorId { get; set; }
        public User? Author { get; set; }

    }
}