using System.Collections.Generic;
using UnityEngine;
using BehaviorTree.Execute;

namespace BehaviorTree.Node
{
    [System.Serializable]
    public class ActionNode : NodeBase
    {
        [SerializeReference, SubclassSelector]
        List<Action> _actionList;

        SequenceNode<Action> _sequenceNode;

        protected override void SetUp()
        {
            _actionList.ForEach(a => a.SetUp(User));
            _sequenceNode = new SequenceNode<Action>(_actionList);
        }

        protected override bool Execute()
        {
            return _sequenceNode.IsProcess;
        }
    }
}