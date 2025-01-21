using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace ToDoList.Models
{
    public class ToDoList
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a description")]
        public string Description { get; set; } = "";

        [Required(ErrorMessage = "Please enter a date")]
        public DateTime? DueDate { get; set; }

        [Required(ErrorMessage = "Please enter a category")]
        public string CategoryId { get; set; } = "";

        [ValidateNever]
        public string Category { get; set; } = null!;
    }
}
