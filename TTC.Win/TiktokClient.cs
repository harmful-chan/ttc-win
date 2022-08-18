﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TikTokLiveSharp.Client;
using TikTokLiveSharp.Events;
using TikTokLiveSharp.Protobuf;
using TTC.Win.Helper;

namespace TTC.Win
{
    internal class TiktokClient : TikTokBaseClient
    {

        public TiktokClient() : base()
        {

        }

        public event EventHandler<WebcastChatMessage> OnCommentRecieved;
        public event EventHandler<ConnectionEventArgs> OnConnected;
        public event EventHandler<ConnectionEventArgs> OnDisconnected;
        public event EventHandler<User> OnFollow;
        //public event EventHandler<WebcastGiftMessage> OnGiftRecieved;
        public event EventHandler<WebcastMemberMessage> OnJoin;
        //public event EventHandler<User> OnLike;
        public event EventHandler<WebcastLikeMessage> OnLikesRecieved;
        //public event EventHandler<WebcastQuestionNewMessage> OnQuestionRecieved;
        //public event EventHandler<User> OnShare;
        public event EventHandler<WebcastRoomUserSeqMessage> OnViewerCountUpdated;
        public event EventHandler<Message> UnhandledEvent;

        protected override async Task<string> Connect()
        {
            var roomID = await base.Connect();
            if (this.Connected && this.OnConnected != null)
            {
                this.OnConnected.Invoke(this, new ConnectionEventArgs(true));
            }
            return roomID;
        }

        protected override async Task Disconnect()
        {
            await base.Disconnect();
            if (!this.Connected && this.OnDisconnected != null)
            {
                this.OnDisconnected.Invoke(this, new ConnectionEventArgs(false));
            }
        }

        protected override void HandleWebcastMessages(WebcastResponse webcastResponse)
        {
            foreach (var message in webcastResponse.Messages)
            {
                LogHelper.Webcast(message.Type);
                this.InvokeEvent(message);
            }
        }

        private void InvokeEvent(Message message)
        {
            using (var stream = new MemoryStream(message.Binary))
                switch (message.Type)
                {
                    // 人数信息更新
                    case nameof(WebcastRoomUserSeqMessage):
                        var roomMessage = ProtoBuf.Serializer.Deserialize<WebcastRoomUserSeqMessage>(stream);
                        if (OnViewerCountUpdated != null)
                            this.OnViewerCountUpdated.Invoke(this, roomMessage);
                        return;

                    // 变更人员信息
                    case nameof(WebcastMemberMessage):
                        var memberMessage = ProtoBuf.Serializer.Deserialize<WebcastMemberMessage>(stream);
                        if (OnJoin != null)
                            this.OnJoin.Invoke(this, memberMessage);
                        return;

                    // 评论
                    case nameof(WebcastChatMessage):
                        var chatMessage = ProtoBuf.Serializer.Deserialize<WebcastChatMessage>(stream);
                        if (OnCommentRecieved != null)
                            this.OnCommentRecieved.Invoke(this, chatMessage);
                        return;
                    case nameof(WebcastLikeMessage):
                        var likeMessage = ProtoBuf.Serializer.Deserialize<WebcastLikeMessage>(stream);
                        if (OnLikesRecieved != null)
                            this.OnLikesRecieved.Invoke(this, likeMessage);
                        return;

                    /*case nameof(WebcastGiftMessage):
                        var giftMessage = ProtoBuf.Serializer.Deserialize<WebcastGiftMessage>(stream);
                        if (OnGiftRecieved != null)
                            this.OnGiftRecieved.Invoke(this, giftMessage);
                        return;*/

                    /*case nameof(WebcastQuestionNewMessage):
                        var questionMessage = ProtoBuf.Serializer.Deserialize<WebcastQuestionNewMessage>(stream);
                        if (OnQuestionRecieved != null)
                            this.OnQuestionRecieved.Invoke(this, questionMessage);
                        return;*/

                    // 关注，pm_main_follow_message_viewer_2
                    case nameof(WebcastSocialMessage):
                        var eventMessage = ProtoBuf.Serializer.Deserialize<WebcastSocialMessage>(stream);
                        this.InvokeSpecialEvent(eventMessage);
                        return;
                }

            if (UnhandledEvent != null)
                this.UnhandledEvent.Invoke(this, message);
        }

        private void InvokeSpecialEvent(WebcastSocialMessage messageEvent)
        {
            LogHelper.Webcast(messageEvent.Event.eventDetails.displayType);
            switch (messageEvent.Event.eventDetails.displayType)
            {
             /*   case "pm_mt_msg_viewer":
                    if (OnLike != null)
                        this.OnLike.Invoke(this, null);
                    return;

                case "live_room_enter_toast":
                    if (OnJoin != null)
                        this.OnJoin.Invoke(this, messageEvent.User);
                    return;*/

                case "pm_main_follow_message_viewer_2":
                    if (OnFollow != null)
                        this.OnFollow.Invoke(this, messageEvent.User);
                    return;

/*                case "pm_mt_guidance_share":
                    if (OnShare != null)
                        this.OnShare.Invoke(this, messageEvent.User);
                    return;*/
            }
        }
    }
}
