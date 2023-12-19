using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Request
{
    public class CreateMembershipStatusRequest
    {
        public int AccountId { get; set; }
        public bool Status { get; set; }
        public DateTime JoinDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
