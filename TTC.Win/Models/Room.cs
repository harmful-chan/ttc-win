using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using TTC.Win.Helper;

namespace TTC.Win.Models
{
    internal class Room : INotifyPropertyChanged
    {
        private Control _control;
        public Room(Control control)
        {
            _control = control;
        }

        public Room()
        {

        }

        private string _uniqueID = "";
        public string UniqueID
        {
            get { return _uniqueID; }
            set { _uniqueID = value; SendChangeInfo("UniqueID"); LogHelper.Param($"UniqueID ... {_uniqueID}"); }
        }


        private string _sessionID = "";
        public string SessionID
        {
            get { return _sessionID; }
            set { _sessionID = value; SendChangeInfo("SessionID"); LogHelper.Param($"SessionID ... {_sessionID}"); }
        }


        private string _roomID = "";
        public string RoomID
        {
            get { return _roomID; }
            set { _roomID = value; SendChangeInfo("RoomID"); LogHelper.Param($"RoomID ... {_roomID}"); }
        }


        private long _viewers = 0;
        public long Viewers
        {
            get { return _viewers; }
            set { _viewers = value; SendChangeInfo("Viewers"); }
        }

        private long _likes = 0;
        public long Likes
        {
            get { return _likes; }
            set { _likes = value; SendChangeInfo("Likes"); }
        }

        private long _followers = 0;
        public long Followers
        {
            get { return _followers; }
            set { _followers = value; SendChangeInfo("Followers"); }
        }

        private long _joined = 0;
        public long Joined
        {
            get { return _joined; }
            set { _joined = value; SendChangeInfo("Joined"); }
        }

        private long _comments = 0;
        public long Comments
        {
            get { return _comments; }
            set { _comments = value; SendChangeInfo("Comments"); }
        }
        private string _uploadAddress;
        public string UploadAddress
        {
            get { return _uploadAddress; }
            set { _uploadAddress = value; SendChangeInfo("UploadAddress"); LogHelper.Param($"UploadAddress ... {_uploadAddress}"); }
        }


        private void SendChangeInfo(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                _control.BeginInvoke(new MethodInvoker(() =>
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                }));
                
            }
        }

        public Room Clone()
        {
            return (Room)this.MemberwiseClone();
        }



        public event PropertyChangedEventHandler PropertyChanged;

    }
}
