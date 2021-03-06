namespace BehaviourTree
{
    /// <summary>
    /// ActionとConditionを作成する際の基底クラス
    /// </summary>
    public abstract class ExecuteBase
    {
        public bool IsExecute => BaseExecute();

        public abstract void BaseInit();

        public abstract void BaseSetup(UnityEngine.GameObject user);

        protected abstract bool BaseExecute();
    }
}