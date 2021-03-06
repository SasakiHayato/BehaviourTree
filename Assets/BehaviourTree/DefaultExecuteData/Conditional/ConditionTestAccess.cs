using UnityEngine;
using BehaviourTree.Execute;

/// <summary>
/// Debug用の条件指定したBoolを返す
/// </summary>
public class ConditionTestAccess : BehaviourConditional
{
    [SerializeField] bool _isAccess;

    protected override bool Try()
    {
        return _isAccess;
    }
}
