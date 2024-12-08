using UnityEngine;

public class IdleState : IState<AiConcreate>
{

    public void Enter(AiConcreate owner)
    {
        // Code for what happens when entering the idle state
    }

    public void Execute(AiConcreate owner)
    {
        // Code to execute each frame when the BlackMagician is idle
        //owner.LookAtPlayer();
    }

    public void Exit(AiConcreate owner)
    {
        // Code for what happens when leaving the idle state
    }
}