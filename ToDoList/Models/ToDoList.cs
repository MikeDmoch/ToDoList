﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace ToDoListProject.Models
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
        public Category Category { get; set; } = null;

        [Required(ErrorMessage = "Please enter a status")]
        public string StatusId { get; set; } = "";

        [ValidateNever]
        public Status Status { get; set; } = null;

        public bool Overdue => StatusId == "open" && DueDate < DateTime.Today;
    }
}
