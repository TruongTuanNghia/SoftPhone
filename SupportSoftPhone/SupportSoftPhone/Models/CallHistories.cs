using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportSoftPhone.Models
{
    public class CallHistoriesResult
    {
        public bool status { get; set; }
        public string message { get; set; }
        public string client_ip { get; set; }
        public List<CallHistories> data { get; set; }
    }
    public class CallHistories
    {
        public Guid u_phone_id { get; set; }
        public string u_call_id { get; set; }
        public string u_phone_agent { get; set; }
        public string u_phone_agent_display { get; set; }
        public string u_phone_client_ip { get; set; }
        public string u_phone_number { get; set; }
        public string u_phone_type { get; set; }
        public string u_phone_status { get; set; }
        public DateTime u_phone_date { get; set; }
    }
}
