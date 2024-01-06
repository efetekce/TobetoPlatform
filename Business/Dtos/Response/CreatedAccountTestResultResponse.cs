using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Response
{
    public class CreatedAccountTestResultResponse
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int TestId { get; set; }
        public int TotalCorrectAnswer { get; set; }
        public int TotalWrongAnswer { get; set; }
        public int TotalBlankAnswer { get; set; }
        public int Points { get; set; }
    }
}
