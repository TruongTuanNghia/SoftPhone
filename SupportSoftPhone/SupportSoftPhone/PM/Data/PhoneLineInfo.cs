using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportSoftPhone.PM.Data
{
    public class PhoneLineInfo
    {
        public bool RegRequired { get; private set; }
        public string DisplayName { get; private set; }
        public string UserName { get; private set; }
        public string RegisterName { get; private set; }
        public string Password { get; private set; }
        public string DomainHost { get; private set; }
        public int DomainPost { get; private set; }
        public PhoneLineInfo(bool regRequired, string displayName, string userName, string registerName, string password, string domainHost, int domainPost)
        {
            RegRequired = regRequired;
            DisplayName = displayName;
            UserName = userName;
            RegisterName = registerName;
            Password = password;
            DomainHost = domainHost;
            DomainPost = domainPost;
        }
    }
}
