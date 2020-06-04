using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Museo.Models
{
    public class Artist
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNac { get; set; }
        public string Descripcion { get; set; }
        //public Artwork Artwork { get; set; }
    }
}