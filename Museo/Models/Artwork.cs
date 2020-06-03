using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Museo.Models
{
    public class Artwork
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public string ImgUrl { get; set; }
        public int ArtistId { get; set; }
        [ForeignKey("ArtistIid")]
        public Artist Artist { get; set; }
    }
}