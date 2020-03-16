using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;
namespace InventarioMeta.Models
{
    public class Maquinas
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Informe o processador")]
        public string Processador { get; set; }
        [Required(ErrorMessage = "Informe a memória RAM")]
        public string RAM { get; set; }
        [Required(ErrorMessage = "Informe o Sistema Operacional")]
        public string SistemaOperacional { get; set; }
        [Required(ErrorMessage = "Informe o tamanho do armazenamento")]
        public int EspacoArmazenamento { get; set; }
        [Required(ErrorMessage = "Informe o adaptador wifi")]
        public string AdaptadorWifi { get; set; }
        [Required(ErrorMessage = "Informe o responsável")]
        public string Responsavel { get; set; }

        [Required(ErrorMessage = "Informe o tipo de armazenamento")]
        public int CodigoTipoArmazenamento { get; set; }
        [NotMapped]
        public List<SelectListItem> TiposArmazenamentos { get; set; }
    }
}