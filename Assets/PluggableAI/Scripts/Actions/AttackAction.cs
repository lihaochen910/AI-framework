using UnityEngine;

/// <summary>
/// 向玩家发射子弹
/// </summary>
[CreateAssetMenu(menuName = "PluggableAI/Actions/Attack")]
public class AttackAction : Action
{
    public override void Act(StateController controller)
    {
        Attack(controller);
    }
    private void Attack(StateController controller)
    {
        controller.tankShooting.Fire(controller.enemyStats.attackForce, controller.enemyStats.attackRate);
    }
}
