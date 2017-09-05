using UnityEngine;

/// <summary>
/// 追踪玩家的行为实现
/// </summary>
[CreateAssetMenu(menuName = "PluggableAI/Actions/Chase")]
public class ChaseAction : Action
{
    public override void Act(StateController controller)
    {
        Chase(controller);
    }

    private void Chase(StateController controller)
    {
        Debug.Assert(controller.chaseTarget != null,"追踪目标为空");

        controller.navMeshAgent.destination = controller.chaseTarget.position;
        controller.navMeshAgent.Resume();
    }
}
