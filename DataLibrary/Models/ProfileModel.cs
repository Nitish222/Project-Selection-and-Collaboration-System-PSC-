using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    class ProfileModel
    {
        public List<String> skills { get; set; }
        public List<String> currentProjectSkills { get; set; }
        public String career { get; set; }
        public String skillScore { get; set; }
    }
}
