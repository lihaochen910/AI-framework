using UnityEngine;
/// <summary>
/// 条件判定具体实现类
/// </summary>
public abstract class Decision : ScriptableObject
{
    /// <summary>
    /// 判定方法
    /// </summary>
    /// <param name="controller"></param>
    /// <returns>判定是否成立</returns>
    public abstract bool Decide(StateController controller);
}
