using UnityEngine;

public class IdleState : IState<MeleeUnit>
{

    public void Enter(MeleeUnit owner)
    {
      Debug.Log("Enter idle state");
      owner.animator.SetInteger("animate",1);
    }

    public void Execute(MeleeUnit owner)
    {
        if (owner.deltaRange <= 10)
        {
            // AttachState <-- owner.isAction = false;
            //
        }
       
        if (owner.deltaRange <= 30)
        {
            owner.stateMachine.ChangeState(new ChasingState());
        }
    }

    public void Exit(MeleeUnit owner)
    {
        Debug.Log("Exit idle state");
    }
}