﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BooksAPI.Entities
{
    [Table("Books")]
    public class Book
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string Title { get; set; }

        [MaxLength(2500)]
        public string? Description { get; set; }

        public Guid AuthorId { get; set; }
        public Author Author { get; set; } = null!;

        public Book(Guid id, Guid authorId, string title, string? description)
        {
            Id = id;
            AuthorId = authorId;
            Title = title;
            Description = description;
        }

        // Esse construtor é necessário para o autoMapper funcionar corretamente (caso não seja configurando ao mapear o DTO no profile)
        //public Book(Guid authorId, string title, string? description)
        //{
        //    AuthorId = authorId;
        //    Title = title;
        //    Description = description;
        //}
    }
}
