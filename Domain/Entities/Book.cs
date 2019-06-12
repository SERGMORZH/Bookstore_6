using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using System;
namespace Domain.Entities
    {
        public class Book
        {

        [HiddenInput(DisplayValue = false)]
        public int BookId { get; set; }

        [Display(Name = "Название")]
        public string Name { get; set; }

        [Display(Name = "Автор")]
        public string Author { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Описание")]
        public string Description { get; set; }

        [Display(Name = "Категория")]
        public string Category { get; set; }

        [Display(Name = "Цена (руб)")]
        public decimal Price { get; set; }
        }
    }

