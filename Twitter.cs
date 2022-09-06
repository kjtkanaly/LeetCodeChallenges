public class Twitter {
    
    public class Tweet
    {
        public int UserId;
        public int PostId;
        
        public Tweet(int UserIdVal, int PostIdVal)
        {
            UserId = UserIdVal;
            PostId = PostIdVal;
        }
    }
    
    public class User
    {
        public int ID;
        public List<int> FollowIDs;
        
        public User(int IDval)
        {
            ID = IDval;
            FollowIDs = new List<int>();
            FollowIDs.Add(IDval);
        }
    }
    
    public List<Tweet> AllTweets;
    public List<User>  AllUsers;
    
    public Twitter() {
        
        AllTweets = new List<Tweet>();
        AllUsers  = new List<User>();
            
    }
    
    public void PostTweet(int userId, int tweetId) {
        
        int UserIndex = AllUsers.Select(x => x.ID).ToList().IndexOf(userId);
        
        if (UserIndex == -1)
        {
            AllUsers.Add(new User(userId));   
        }
        
        AllTweets.Insert(0, new Tweet(userId, tweetId));
    }
    
    public IList<int> GetNewsFeed(int userId) {
        
        List<int> Tweets = new List<int>();
        
        int UserIndex = AllUsers.Select(x => x.ID).ToList().IndexOf(userId);

        for (int i = 0; i < AllTweets.Count; i++)
        {
            if (AllUsers[UserIndex].FollowIDs.Contains(AllTweets[i].UserId))
            {
                Tweets.Add(AllTweets[i].PostId);   
            }
            if (Tweets.Count == 10)
            {
                return Tweets;
            }
        }
        
        return Tweets;
    }
    
    public void Follow(int followerId, int followeeId) {
        
        int UserIndex = AllUsers.Select(x => x.ID).ToList().IndexOf(followerId);
        
        if (UserIndex != -1)
        {
            AllUsers[UserIndex].FollowIDs.Add(followeeId);    
        }
        else
        {
            AllUsers.Add(new User(followerId));
            AllUsers[AllUsers.Count - 1].FollowIDs.Add(followeeId);
        }
        
    }
    
    public void Unfollow(int followerId, int followeeId) {
        int UserIndex = AllUsers.Select(x => x.ID).ToList().IndexOf(followerId);
        
        AllUsers[UserIndex].FollowIDs.Remove(followeeId);
    }
}

/**
 * Your Twitter object will be instantiated and called as such:
 * Twitter obj = new Twitter();
 * obj.PostTweet(userId,tweetId);
 * IList<int> param_2 = obj.GetNewsFeed(userId);
 * obj.Follow(followerId,followeeId);
 * obj.Unfollow(followerId,followeeId);
 */
// AllTweets.Find(x => x.UserId == userId).ToList().Select(x => x.PostId).ToList()