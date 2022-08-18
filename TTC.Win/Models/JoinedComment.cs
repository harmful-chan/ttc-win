using System;
using System.Collections.Generic;
using System.Text;

namespace TTC.Win.Models
{
    internal class JoinedComment : Comment
    {
        public JoinedComment(string nickName) : base(null, nickName, "joined", false) { }
    }
}
