//------------------------------------------------------------------------------
// <auto-generated>
//    O código foi gerado a partir de um modelo.
//
//    Alterações manuais neste arquivo podem provocar comportamento inesperado no aplicativo.
//    Alterações manuais neste arquivo serão substituídas se o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dominio.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbMaquinas
    {
        public int Id { get; set; }
        public string Processador { get; set; }
        public string RAM { get; set; }
        public string SistemaOperacional { get; set; }
        public int CodigoTipoArmazenamento { get; set; }
        public string AdaptadorWifi { get; set; }
        public string Responsavel { get; set; }
        public int EspacoArmazenamento { get; set; }
    }
}