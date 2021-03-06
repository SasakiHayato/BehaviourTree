using UnityEngine;

namespace BehaviourTree.Data
{
    /// <summary>
    /// BehaviorTreeUserのデータクラス
    /// </summary>
    public class BehaviourTreeUserData
    {
        public BehaviourTreeUserData(BehaviourTreeUser user, Transform transform, string path)
        {
            Offset = transform;
            User = user;
            UserPath = path;
        }

        public string UserPath { get; private set; }

        public string IOPath { get; private set; }

        public Transform Offset { get; private set; }

        public BehaviourTreeUser User { get; private set; }
        
        public int LimitConditionalCount { get; private set; }

        public void SetLimitConditionalCount(int count) => LimitConditionalCount = count;
        
        public bool IsLimitCondition() => LimitConditionalCount > 0;

        public void SetIOPath(string path) => IOPath = path;
    }
}
