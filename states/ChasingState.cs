using UnityEngine;

public class ChasingState : IState<MeleeUnit>
{

    public void Enter(MeleeUnit owner)
    {
        Debug.Log("Enter Chasing state");
        owner.animator.SetInteger("animate",2);
    }

    public void Execute(MeleeUnit owner)
    {
        owner.ChasePlayer();
        if (owner.deltaRange > 30)
        {
            owner.stateMachine.ChangeState(new IdleState());
        }
        
    }

    public void Exit(MeleeUnit owner)
    {
        Debug.Log("Exit Chasing state");
    }
}