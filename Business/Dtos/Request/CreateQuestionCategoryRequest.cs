using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Request
{
    public class CreateQuestionCategoryRequest
    {
        public string Name { get; set; }
        public int Priority { get; set; }
    }
}
