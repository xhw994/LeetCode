using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public static partial class LeetCode_351_400
    {
        public class Twitter
        {
            private Dictionary<int, User> users;

            /** Initialize your data structure here. */
            public Twitter()
            {
                users = new Dictionary<int, User>();
            }

            /** Compose a new tweet. */
            public void PostTweet(int userId, int tweetId)
            {
                if (!users.ContainsKey(userId))
                {
                    users.Add(userId, new User
                    {
                        Followee = new HashSet<int>() { userId },
                        Feed = new Queue<int>()
                    });
                }

                foreach (int fle in users[userId].Followee)
                {
                    AddToFeed(fle, tweetId);
                }
            }

            /** Retrieve the 10 most recent tweet ids in the user's news feed. Each item in the news feed must be posted by users who the user followed or by the user herself. Tweets must be ordered from most recent to least recent. */
            public IList<int> GetNewsFeed(int userId)
            {
                List<int> ret = new List<int>();
                if (users.ContainsKey(userId))
                {
                    foreach (int f in users[userId].Feed) ret.Add(f);
                }

                return ret;
            }

            /** Follower follows a followee. If the operation is invalid, it should be a no-op. */
            public void Follow(int followerId, int followeeId)
            {
                if (!users.ContainsKey(followerId))
                {
                    users.Add(followerId, new User
                    {
                        Followee = new HashSet<int>() { followerId },
                    });
                }

                if (!users.ContainsKey(followeeId))
                {
                    users.Add(followerId, new User
                    {
                        Followee = new HashSet<int>() { followerId, followeeId }
                    });
                }

                users[followerId].Followee.Add(followeeId);
            }

            /** Follower unfollows a followee. If the operation is invalid, it should be a no-op. */
            public void Unfollow(int followerId, int followeeId)
            {
                if (!users.ContainsKey(followerId)) return;
                users[followerId].Followee.Remove(followeeId);
            }

            private struct User
            {
                public HashSet<int> Followee;
                public Queue<int> Feed;
            }

            private void AddToFeed(int userId, int tweetId)
            {
                Queue<int> feed = users[userId].Feed;
                if (feed.Count == 10) feed.Dequeue();
                feed.Enqueue(tweetId);
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
    }
}
