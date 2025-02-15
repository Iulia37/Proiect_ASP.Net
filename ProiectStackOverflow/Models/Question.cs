﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProiectStackOverflow.Models
{
	public class Question
	{
		[Key]
		public int Id { get; set; }
		[Required(ErrorMessage = "Title is mandatory")]
		public string Title { get; set; }
		[Required(ErrorMessage = "Content is mandatory")]
		[MinLength(10, ErrorMessage = "The content must be at least 10 characters long.")]
		public string Content { get; set; }
		public DateTime Date { get; set; }
		public string? UserId { get; set; }
        [Required(ErrorMessage = "Tag is required")]
        public int? TagId { get; set; }
        public virtual ApplicationUser? User { get; set; }
        public virtual Tag? Tag { get; set; }
		public virtual ICollection<Comment>? Comments { get; set; }
		public virtual ICollection<Answer>? Answers { get; set; }

		[NotMapped]
		public IEnumerable<SelectListItem>? T { get; set; }
		[NotMapped]
        public Comment? Comment { get; set; }
        [NotMapped]
        public Answer? Answer { get; set; }
    }
}
