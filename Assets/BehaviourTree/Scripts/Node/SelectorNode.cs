using System.Collections.Generic;
using System.Linq;

namespace BehaviourTree.Node
{
    /// <summary>
    /// どれかの実行を操作するノード
    /// 
    /// System.Linq Any()の働き
    /// </summary>
    /// <typeparam name="Execution"></typeparam>
    
    public class SelectorNode<Execution> : NodeBase where Execution : ExecuteBase
    {
        List<Execution> _executeList;
        public SelectorNode(List<Execution> type)
        {
            _executeList = type;
        }

        public override void SetUp() { }

        protected override bool Execute()
        {
            return _executeList.Any(e => e.IsExecute);
        }
    }
}
