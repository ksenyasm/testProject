using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace testProject.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Имя")]
        [MaxLength(50)]
        [Required(ErrorMessage="Необходимо ввести имя")]
        public string Name { get; set; }

        [Display(Name = "Пароль")]
        public string Password { get; set; }

        //[Display(Name = "О себе")]
        public string About { get; set; }
    }
}
