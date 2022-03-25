using System;
using System.ComponentModel.DataAnnotations;

namespace _1911061533_DanhHongVan_BigSchool.Models
{
    public class Course
    {
        private Category category;

        public int Id { get; set; }

        public ApplicationUser Lecturer { get; set; }
        [Required]
        public string LecturerId { get; set; }

        [Required]
        [StringLength(255)]
        public string Place { get; set; }

        public DateTime DateTime { get; set; }

        public Category Category { get; set; }

        [Required]
        public byte CategoryId { get; set; }

        //public DateTime DataTime { get; internal set; }
        


    }




}