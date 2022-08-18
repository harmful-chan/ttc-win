using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TTC.Win.Extensions;
using TTC.Win.Models;

namespace TTC.Win.Helper
{
    internal static class HistoryHelper
    {
        readonly static string _historyTempPath = Path.Combine(Path.GetTempPath(), "ttc", "history");

        static HistoryHelper()
        {
            if(!Directory.Exists(_historyTempPath))
                Directory.CreateDirectory(_historyTempPath);
        }

        public static bool RoomExists(string roomID)
        {
            string _historyRoomFileName = Path.Combine(_historyTempPath, roomID.Legal() ? roomID : "room");
            return File.Exists(_historyRoomFileName);
        }
        public static async Task<bool> SaveRoom(Room room)
        {
            string _historyRoomFileName = Path.Combine(_historyTempPath, (room.RoomID.Legal() ? room.RoomID : "room"));
            return await Save<Room>(_historyRoomFileName, room);
        }

        public static async Task<Room> RecoverRoom(string roomID)
        {
            string _historyRoomFileName = Path.Combine(_historyTempPath, roomID.Legal() ? roomID : "room");
            return await Recover<Room>(_historyRoomFileName);
        }

        public static async Task<bool> SaveComment(string roomID, List<Comment> commentList)
        {
            string _historyCommentFileName = Path.Combine(_historyTempPath, $"{roomID}_comment");
            return await Save<List<Comment>>(_historyCommentFileName, commentList);
        }
        public static async Task<List<Comment>> RecoverComment(string roomID)
        {
            string _historyRoomFileName = Path.Combine(_historyTempPath, $"{roomID}_comment");
            return await Recover<List<Comment>>(_historyRoomFileName);
        }

        public static async Task<bool> SaveJoined(string roomID, List<string> joinedList)
        {
            string _historyJoinedFileName = Path.Combine(_historyTempPath, $"{roomID}_joined");
            return await Save<List<string>>(_historyJoinedFileName, joinedList);
        }

        public static async Task<List<string>> RecoverJoined(string roomID)
        {
            string _historyRoomFileName = Path.Combine(_historyTempPath, $"{roomID}_joined");
            return await Recover<List<string>>(_historyRoomFileName);
        }

        static Task<bool> Save<T>(string fileName, T t) where T : class
        {
            return Task.Run(() =>
            {
                if (!fileName.Legal() || t == null)
                    return false;

                lock (fileName)
                {
                    if (!File.Exists(fileName))
                        File.Create(fileName);
                    try
                    {
                        string ser = JsonSerializer.Serialize<T>(t);
                        File.WriteAllText(fileName, ser);
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }
                    return true;
                }

            });
        }

        static Task<T> Recover<T>(string fileName) where T : class, new()
        {
            return Task.Run(() =>
            {
                if (!fileName.Legal() )
                    return null;

                lock (fileName)
                {
                    T t=null;
                    if (File.Exists(fileName))
                    {
                        try
                        {
                            string v = File.ReadAllText(fileName);
                            t = JsonSerializer.Deserialize<T>(v);
                        }
                        catch (Exception e)
                        {
                            return new T();
                        }
                    }
                    return t;
                }

            });
        }
    }
}
