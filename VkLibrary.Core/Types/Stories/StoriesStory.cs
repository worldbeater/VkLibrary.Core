using System;
using Newtonsoft.Json;
using VkApi.Wrapper.Types.Photos;

namespace VkApi.Wrapper.Types.Stories
{
    public class StoriesStory
    {
        ///<summary>
        /// Access key for private object.
        ///</summary>
        [JsonProperty("access_key")]
        public String AccessKey { get; set; }

        ///<summary>
        /// Information whether current user can comment the story (0 - no, 1 - yes).
        ///</summary>
        [JsonProperty("can_comment")]
        public int CanComment { get; set; }

        ///<summary>
        /// Information whether current user can reply to the story (0 - no, 1 - yes).
        ///</summary>
        [JsonProperty("can_reply")]
        public int CanReply { get; set; }

        ///<summary>
        /// Information whether current user can see the story (0 - no, 1 - yes).
        ///</summary>
        [JsonProperty("can_see")]
        public int CanSee { get; set; }

        ///<summary>
        /// Information whether current user can share the story (0 - no, 1 - yes).
        ///</summary>
        [JsonProperty("can_share")]
        public int CanShare { get; set; }

        ///<summary>
        /// Date when story has been added in Unixtime.
        ///</summary>
        [JsonProperty("date")]
        public int Date { get; set; }

        ///<summary>
        /// Story expiration time. Unixtime.
        ///</summary>
        [JsonProperty("expires_at")]
        public int ExpiresAt { get; set; }

        ///<summary>
        /// Story ID.
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// Information whether the story is deleted (false - no, true - yes).
        ///</summary>
        [JsonProperty("is_deleted")]
        public Boolean IsDeleted { get; set; }

        ///<summary>
        /// Information whether the story is expired (false - no, true - yes).
        ///</summary>
        [JsonProperty("is_expired")]
        public Boolean IsExpired { get; set; }
        [JsonProperty("link")]
        public StoriesStoryLink Link { get; set; }

        ///<summary>
        /// Story owner's ID.
        ///</summary>
        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }
        [JsonProperty("parent_story")]
        public StoriesStory ParentStory { get; set; }

        ///<summary>
        /// Access key for private object.
        ///</summary>
        [JsonProperty("parent_story_access_key")]
        public String ParentStoryAccessKey { get; set; }

        ///<summary>
        /// Parent story ID.
        ///</summary>
        [JsonProperty("parent_story_id")]
        public int ParentStoryId { get; set; }

        ///<summary>
        /// Parent story owner's ID.
        ///</summary>
        [JsonProperty("parent_story_owner_id")]
        public int ParentStoryOwnerId { get; set; }
        [JsonProperty("photo")]
        public PhotosPhoto Photo { get; set; }

        ///<summary>
        /// Replies to current story.
        ///</summary>
        [JsonProperty("replies")]
        public StoriesReplies Replies { get; set; }

        ///<summary>
        /// Information whether current user has seen the story or not (0 - no, 1 - yes).
        ///</summary>
        [JsonProperty("seen")]
        public int Seen { get; set; }
        [JsonProperty("type")]
        public StoriesStoryType Type { get; set; }
        [JsonProperty("video")]
        public StoriesStoryVideo Video { get; set; }

        ///<summary>
        /// Views number.
        ///</summary>
        [JsonProperty("views")]
        public int Views { get; set; }

        ///<summary>
        /// Does author have stories privacy restrictions
        ///</summary>
        [JsonProperty("is_restricted")]
        public Boolean IsRestricted { get; set; }

        ///<summary>
        /// Is video without sound
        ///</summary>
        [JsonProperty("no_sound")]
        public Boolean NoSound { get; set; }

        ///<summary>
        /// Does video need to be muted
        ///</summary>
        [JsonProperty("need_mute")]
        public Boolean NeedMute { get; set; }

        ///<summary>
        /// Information whether story has question sticker and current user can send question to the author
        ///</summary>
        [JsonProperty("can_ask")]
        public int CanAsk { get; set; }

        ///<summary>
        /// Information whether story has question sticker and current user can send anonymous question to the author
        ///</summary>
        [JsonProperty("can_ask_anonymous")]
        public int CanAskAnonymous { get; set; }
    }
}