using UnityEngine;

/// <summary>
/// 判定追踪玩家是否超出了最大范围/玩家死亡
/// </summary>
[CreateAssetMenu(menuName = "PluggableAI/Decisions/Chase")]
public class ChaseDecision : Decision
{
    public float MaxChaseDistance = 10f;
    public override bool Decide(StateController controller)
    {
        // 目标Transform丢失
        if (!controller.chaseTarget)
            return false;

        // 目标是否超出范围
        return getDistance(controller) < MaxChaseDistance ? true : false;
    }

    private float getDistance(StateController controller)
    {
        return Vector3.Distance(controller.transform.position, controller.chaseTarget.position);
    }
}
