using System;
using System.Collections.Generic;
using System.Text;

namespace TTC.Win.Models
{
    internal class FollowComment : Comment
    {
        public FollowComment(string nickName) : base(null, nickName, "follow", false) { }
    }
}
