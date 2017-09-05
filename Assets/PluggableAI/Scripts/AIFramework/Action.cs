using UnityEngine;
/// <summary>
/// 行为抽象类
/// </summary>
public abstract class Action : ScriptableObject {
    /// <summary>
    /// 行为具体实现
    /// </summary>
    /// <param name="controller">状态控制器</param>
    public abstract void Act(StateController controller);
}
