using System;
using System.Collections.Generic;
using System.Text;

namespace TTC.Win.Models
{
    public class Comment
    {
        public Comment()
        {

        }
        public Comment(string iconUrl, string nickName, string raw, bool isTranslate)
        {
            IconUrl = iconUrl;
            NickName = nickName;
            Raw = raw;
            IsTranslate = isTranslate;
        }

        public string IconUrl { get; set; }
        public string NickName { get; set; }
        public string Raw { get; set; }
        public bool IsTranslate { get; set; } =true;
    }

}
