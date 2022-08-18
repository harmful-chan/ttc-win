using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TTC.Win.Utils
{
    internal static class Tcping
    {

        internal async static Task<double> Ping5Async(string ip, int port)
        {
            List<double> result = new List<double>();
            for (int i = 0; i < 5; i++)
            {
                var time = await Tcping.PingAsync(ip, port);
                result.Add(time);
            }

            return result.Average();
        }
        internal async static Task<double> PingAsync(string ip, int port)
        {
            double time = double.MaxValue;
            await Task<double>.Run(() =>
            {
        
                var sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                sock.Blocking = true;
                var stopwatch = new Stopwatch();
                try
                {
                    stopwatch.Start();
                    IAsyncResult asyncResult = sock.BeginConnect(ip, port, null, null);
                    if( !asyncResult.AsyncWaitHandle.WaitOne(TimeSpan.FromMilliseconds(200)))
                        throw new TimeoutException("connect timeout!");
                }
                catch(Exception e)
                {

                }
                finally
                {
                    stopwatch.Stop();
                    time = stopwatch.Elapsed.TotalMilliseconds;
                    sock.Close();
                    Thread.Sleep(100);
                }
            });
            return time;
        }
    }
}
