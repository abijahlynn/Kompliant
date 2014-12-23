using System.Collections.Generic;
using System.Reflection.Emit;

namespace Kompliant.Model
{
    public class Requirement
    {
        public Requirement()
        {
            Standards = new List<Standard>();
        }

        public int Id { get; set; }
        public string RequirementId { get; set;  }
        public string Description { get; set;  }
        public string Period { get; set; }

        public int TopicId { get; set; }

        // navigation
        public virtual Topic Topic { get; set; }
        public virtual ICollection<Standard> Standards { get; set; }
    }
}