using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using System;
namespace Domain.Entities
    {
        public class Book
        {

        [HiddenInput(DisplayValue = false)]
        public int BookId { get; set; }

        [Display(Name = "��������")]
        public string Name { get; set; }

        [Display(Name = "�����")]
        public string Author { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "��������")]
        public string Description { get; set; }

        [Display(Name = "���������")]
        public string Category { get; set; }

        [Display(Name = "���� (���)")]
        public decimal Price { get; set; }
        }
    }

