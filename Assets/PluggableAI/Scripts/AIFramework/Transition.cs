/// <summary>
/// 条件变换类
/// </summary>
[System.Serializable]
public class Transition
{
    /// <summary>
    /// 条件判定方法类
    /// </summary>
    public Decision decision;
    /// <summary>
    /// 条件成立时，切换为true的状态
    /// </summary>
    public State trueState;
    /// <summary>
    /// 条件成立时，切换为false的状态
    /// </summary>
    public State falseState;
}
