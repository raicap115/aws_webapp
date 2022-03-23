using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aws_webapp{
    public class Participantes{
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required(ErrorMessage="Ingrese su nombre")]
        [Display(Name="Nombre:")]
        public string nombre { get; set; }
        [Required(ErrorMessage="Ingrese su apellido")]
        [Display(Name="Apellido:")]
        public string apellido { get; set; }
        [Required(ErrorMessage="Ingrese su edad")]
        [Display(Name="Edad:")]
        public string edad { get; set; }
        [Display(Name="Género:")]
        public string genero { get; set; }
        [Required(ErrorMessage="Ingrese su ciudad")]
        [Display(Name="Ciudad:")]
        public string ciudad { get; set; }
        [Required(ErrorMessage="Ingrese el tiempo en minutos")]
        [Display(Name="Tiempo (en min):")]
        public double tiempo { get; set; }
        [Required(ErrorMessage="Ingrese la distancia en kilómetros")]
        [Display(Name="Distancia (en km):")]
        public double distancia { get; set; }
        [Required(ErrorMessage="Ingrese su ritmo promedio")]
        [Display(Name="Ritmo:")]
        public double ritmo { get; set; }
        [Required(ErrorMessage="Ingrese el lugar")]
        [Display(Name="Lugar:")]
        public string lugar { get; set; }
        [Required(ErrorMessage="Ingrese su rol en el Team")]
        [Display(Name="Rol:")]
        public string rol { get; set; }
        [Required(ErrorMessage="Ingrese su correo institucional")]
        [Display(Name="Email:")]
        public string correo { get; set; }
    }
}