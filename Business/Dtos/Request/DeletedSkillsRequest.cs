using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Request
{
    public class DeletedSkillsRequest
    {
        public int Id { get; set; }
        public string Skill { get; set; }
    }
}
