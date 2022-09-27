using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PSC_System.Data.Model
{
    public class CollaborationMLModel
    {
        public int Id = 1;

        public string UserID { get; set; }
        
        public float CurrentProject { get; set; }
        
        public float SkillRelevance { get; set; }
       
        public float SkillScore { get; set; }
    }
}
