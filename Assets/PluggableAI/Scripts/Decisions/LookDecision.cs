using UnityEngine;

[CreateAssetMenu(menuName = "PluggableAI/Decisions/Look")]
public class LookDecision : Decision
{
    public override bool Decide(StateController controller)
    {
        bool isVisiable = Look(controller);

        return isVisiable; 
    }

    private bool Look(StateController controller)
    {
        RaycastHit hit;

        Debug.DrawRay(controller.eyes.position,controller.eyes.forward.normalized * controller.enemyStats.lookRange,Color.green);

        if (Physics.SphereCast(
            controller.eyes.transform.position,
            controller.enemyStats.lookSphereCastRadius,
            controller.eyes.forward.normalized,
            out hit, controller.enemyStats.lookRange) &&
            hit.transform.CompareTag("Player"))
        {
            controller.chaseTarget = hit.transform;
            return true;
        }
        else return false;
    }
}
