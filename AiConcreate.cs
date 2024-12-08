using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiConcreate : MonoBehaviour
{
    public StateMachine<AiConcreate> stateMachine;
    void Start()
    {
        stateMachine = new StateMachine<AiConcreate>(this);
        stateMachine.ChangeState(new IdleState())
    }
    // Update is called once per frame
    void Update()
    {
        stateMachine.Update();
    }
}