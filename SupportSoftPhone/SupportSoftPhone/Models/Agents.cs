using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportSoftPhone.Models
{
    public class AgentsResult
    {
        public bool status { get; set; }
        public string message { get; set; }
        public string client_ip { get; set; }
        public Agents data { get; set; }
    }
    public class Agents
    {
        public int u_id { get; set; }
        public string u_username { get; set; }
        public string u_alias { get; set; }
        public string u_email { get; set; }
        public string u_phone_agent { get; set; }
        public string u_phone_agent_password { get; set; }
        public string u_phone_queue { get; set; }
        public string u_phone_server { get; set; }
        public int u_phone_server_port { get; set; }
        public string u_phone_server_type { get; set; }
        public string u_call_note_url { get; set; }
        public string u_phone_browser_default { get; set; }
        public string u_client_ip { get; set; }
        public bool is_online { get; set; }
        public bool is_ticket_only { get; set; }
        public bool is_break { get; set; }
        public string break_reason { get; set; }
        public Nullable<DateTime> start_date { get; set; }
        public Nullable<DateTime> end_date { get; set; }
        public Nullable<DateTime> last_online_date { get; set; }
        public Nullable<DateTime> last_callanswer_date { get; set; }
        public Nullable<DateTime> last_ticketanswer_date { get; set; }
    }
    public class BaseResult
    {
        public bool status { get; set; }
        public string message { get; set; }
        public string client_ip { get; set; }
        public object data { get; set; }
    }
}
