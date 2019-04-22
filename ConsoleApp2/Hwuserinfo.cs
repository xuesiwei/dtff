using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class HwUserInfo
    {
        public result result { get; set; }

        public int code { get; set; }
    }

    public class result
    {
        public int totalCount { get; set; }

        public int page { get; set; }

        public List<list> list { get; set; }
    }

    public class list
    {
        public user user { get; set; }

        public userExt userExt { get; set; }

        public userStatistic userStatistic { get; set; }

        public sasUser sasUser { get; set; }

        public sasUserStatistic sasUserStatistic { get; set; }
    }

    public class sasUserStatistic
    {
        public int id { get; set; }

        public int sasId { get; set; }

        public int userId { get; set; }

        public int forumCount { get; set; }

        public int activityApplySuccessOrderCount { get; set; }

        public int activityApplyOrderCount { get; set; }

        public int goodBuySuccessOrderCount { get; set; }

        public int goodBuyOrderCount { get; set; }

        public int forumReplyCount { get; set; }

        public int articleCommentCount { get; set; }

        public int photoUploadCount { get; set; }

        public int userTrackCount { get; set; }

        public int adminTrackCount { get; set; }

        public int notificationCount { get; set; }

        public int notificationUnReadCount { get; set; }

        public int lastReadSystemNotificationTime { get; set; }

        public int creditPointBalance { get; set; }

        public int creditPointHistoryCount { get; set; }

        public int cartGoodsCount { get; set; }

        public int cartGoodsBuyCount { get; set; }

        public int cartActivityCount { get; set; }

        public int cartActivityApplierCount { get; set; }

        public int disJoinActivityCount { get; set; }

        public int totalCouponCount { get; set; }

        public int totalUnusedCouponCount { get; set; }

        public int totalUsedCouponCount { get; set; }

        public int totalExpiredCouponCount { get; set; }
    }

    public class sasUser
    {
        public int id { get; set; }

        public int sasId { get; set; }

        public int userId { get; set; }

        public string state { get; set; }

        public string type { get; set; }

        public int level { get; set; }

        public string memberExpireTime { get; set; }

        public string lastLoginTime { get; set; }

        public string resaleType { get; set; }

        public int lastResaleUserId { get; set; }

        public string createTime { get; set; }
    }

    public class userStatistic
    {
        public int userId { get; set; }

        public int applyerCount { get; set; }
    }

    public class userExt
    {
        public int userId { get; set; }

        public string trueName { get; set; }

        public string identityCode { get; set; }

        public string sex { get; set; }

        public string livingProvince { get; set; }

        public string livingCity { get; set; }

        public string livingAddress { get; set; }

        public string deliveryProvince { get; set; }

        public string deliveryCity { get; set; }

        public string deliveryAddress { get; set; }

        public string emergencyContactPerson { get; set; }

        public string emergencyContactPhone { get; set; }

        public int birthdayTime { get; set; }

        public string hobby { get; set; }
    }

    public class user
    {
        public int id { get; set; }

        public string email { get; set; }

        public string phone { get; set; }

        public string password { get; set; }

        public int sourceSasId { get; set; }

        public string nickname { get; set; }

        public string avatarUrl { get; set; }

        public string lastLoginTime { get; set; }

        public string createTime { get; set; }

        public int thirdpartAccountState { get; set; }

        public string state { get; set; }

        public bool userValid { get; set; }
    }
}