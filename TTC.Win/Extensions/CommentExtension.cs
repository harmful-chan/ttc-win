using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using TTC.Win.Models;

namespace TTC.Win.Extensions
{
    internal static class CommentExtension
    {
        internal static void AppendComment(this List<Comment> commentList, Comment c)
        {
            commentList.Add(c);
        }

    }
}
