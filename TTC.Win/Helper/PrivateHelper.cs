using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using TTC.Win.Extensions;
using TTC.Win.Models;

namespace TTC.Win.Helper
{
    internal static class PrivateHelper
    {
        private static readonly string _privateTempPath = Path.Combine(Path.GetTempPath(), "ttc", "private");
        private static readonly string _privateFileName = Path.Combine(Path.GetTempPath(), "ttc", "private", "private.json");
        internal static string PrivateFileName => _privateFileName;
        private static string TempPrivate()
        {
            return "[ \r\n\t{ \"UniqueID\": \"fbs.students\", \"SessionID\": \"aaeeb8db89c07eba82bb01127cbf149d\", \"Expiration\": 1665290552 }," +
                   "\r\n\t{ \"UniqueID\": \"lamore.girl\", \"SessionID\": \"93fa89837ce65986a20c7acd803a59e6\", \"Expiration\": 1665290552 }, " +
                   "\r\n\t{ \"UniqueID\": \"yoyo.babies\", \"SessionID\": \"d037ade1c6f3d075e3cf2d806e820884\", \"Expiration\": 1665290552 }, " +
                   "\r\n\t{ \"UniqueID\": \"go.pukka\", \"SessionID\": \"215f4d11ae227b943d7ced0307d73ff9\", \"Expiration\": 1665290552 }," +
                   "\r\n\t{ \"UniqueID\": \"hibobi.uk\", \"SessionID\": \"e2b050bd8681f726199078b2e5a10ec6\", \"Expiration\": 1665290552 } \r\n]";
        }

       
        static PrivateHelper()
        {
            if (!Directory.Exists(_privateTempPath))
                Directory.CreateDirectory(_privateTempPath);

            if (!File.Exists(_privateFileName))
                File.Create(_privateFileName);
        }


        internal static string GetPrivate()
        {
            string str = File.ReadAllText(_privateFileName);

            if (!str.Legal())
            {
                str = TempPrivate();
            }
            return str;
        }
        internal static void SavePrivate(string str)
        {
            File.WriteAllText(_privateFileName, str);
        }
    }
}
