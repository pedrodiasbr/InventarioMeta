using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InventarioMeta.Models
{
    public class Maquinas
    {
        [Key]
        public int Id { get; set; }
        public string Processador { get; set; }
        public string RAM { get; set; }
        public string SistemaOperacional { get; set; }
        public int EspacoArmazenamento { get; set; }
        public string AdaptadorWifi { get; set; }
        public string Responsavel { get; set; }

        [Required(ErrorMessage = "Informe o tipo de armazenamento")]
        public int CodigoTipoArmazenamento { get; set; }

        public List<SelectListItem> TiposArmazenamentos { get; set; }
    }
}