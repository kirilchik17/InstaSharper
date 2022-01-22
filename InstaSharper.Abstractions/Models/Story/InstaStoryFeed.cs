﻿using System.Collections.Generic;

namespace InstaSharper.Abstractions.Models.Story;

public class InstaStoryFeed
{
    public int FaceFilterNuxVersion { get; set; }

    public bool HasNewNuxStory { get; set; }

    public string StoryRankingToken { get; set; }

    public int StickerVersion { get; set; }

    public List<InstaReelFeedItem> Items { get; set; } = new();

    //public List<InstaBroadcast> Broadcasts { get; set; } = new();

    //public List<InstaBroadcastAddToPostLive> PostLives { get; set; } = new();

    //public List<InstaHashtagStory> HashtagStories { get; set; } = new();
}