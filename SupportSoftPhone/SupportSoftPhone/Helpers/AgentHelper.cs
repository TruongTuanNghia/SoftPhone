using Newtonsoft.Json;
using SupportSoftPhone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportSoftPhone.Helpers
{
    public class AgentHelper
    {
        public static Agents GetAgentAccountByEmail(string email)
        {
            //var jsonPostData = JsonConvert.SerializeObject(new
            //{
            //    email = email,
            //    clientip = Utils.GetClientIPAddress
            //}, Formatting.Indented);
            //var client = new WebServices("get-agent-by-email", jsonPostData);
            //var result = JsonConvert.DeserializeObject<AgentsResult>(client.Post());
            //if ((result.status) && (result.data != null))
            //    return result.data;
            return (Agents)null;
        }
        public static List<CallHistories> GetCallRecentlyHistories(Agents agent)
        {
            //var jsonPostData = JsonConvert.SerializeObject(new
            //{
            //    u_phone_agent = agent.u_phone_agent
            //}, Formatting.Indented);
            //var client = new WebServices("get-agent-recently-histories", jsonPostData);
            //var result = JsonConvert.DeserializeObject<CallHistoriesResult>(client.Post());
            //if ((result.status) && (result.data != null))
            //    return result.data;
            return null;
        }
        public static List<CallHistories> GetCallRecentlyHistoriesString(string agent)
        {
            //var jsonPostData = JsonConvert.SerializeObject(new
            //{
            //    u_phone_agent = agent
            //}, Formatting.Indented);
            //var client = new WebServices("get-agent-recently-histories", jsonPostData);
            //var result = JsonConvert.DeserializeObject<CallHistoriesResult>(client.Post());
            //if ((result.status) && (result.data != null))
            //    return result.data;
            return null;
        }
        //public static bool AppendToHistoryList(Agents agent, string callID, string phoneNumber, string callType, string callStatus)
        //{
        //    try
        //    {
        //        var jsonPostData = JsonConvert.SerializeObject(new
        //        {
        //            u_call_id = callID,
        //            u_phone_agent = agent.u_phone_agent,
        //            u_phone_agent_display = agent.u_username,
        //            u_phone_client_ip = Utils.GetClientIPAddress,
        //            u_phone_number = phoneNumber,
        //            u_phone_type = callType,
        //            u_phone_status = callStatus
        //        }, Formatting.Indented);

        //        var client = new WebServices("add-agent-history", jsonPostData);
        //        var result = JsonConvert.DeserializeObject<CallHistoriesResult>(client.Post());
        //        return ((result.status) && (result.data.Count > 0));
        //    }
        //    catch { return false; }
        //}
        //public static bool UpdateHistoryStatus(Agents agent, string callID, string callStatus)
        //{
        //    try
        //    {
        //        var jsonPostData = JsonConvert.SerializeObject(new
        //        {
        //            u_call_id = callID,
        //            u_id = agent.u_id,
        //            u_phone_status = callStatus
        //        }, Formatting.Indented);

        //        var client = new WebServices("update-agent-history-status", jsonPostData);
        //        var result = JsonConvert.DeserializeObject<CallHistoriesResult>(client.Post());
        //        return ((result.status) && (result.data.Count > 0));
        //    }
        //    catch { return false; }
        //}
    }
}
