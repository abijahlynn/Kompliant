using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kompliant.Model
{
    public class Standard
    {
        public int Id { get; set; }
        public string StandardId { get; set; }
        public string Description { get; set; }

        public int GoverningBodyId { get; set; }

        // navigation
        public virtual GoverningBody GoverningBody { get; set; }
    }
}