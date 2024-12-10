using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeUnit : MonoBehaviour
{
    public StateMachine<MeleeUnit> stateMachine;
    public Animator animator;
    public float maxHealth = 100;
    public float deltaRange = 100;
    void Start()
    {
        stateMachine = new StateMachine<MeleeUnit>(this);
        animator = gameObject.GetComponent<Animator>();
        stateMachine.ChangeState(new IdleState());
    }
    // Update is called once per frame
    void Update()
    {
        stateMachine.Update();
     

        if (Input.GetKeyDown(KeyCode.W))
        {
            deltaRange -= 10;
            Debug.Log(deltaRange+" : DeltaRange");
        }
        
        if (Input.GetKeyDown(KeyCode.S))
        {
            deltaRange += 10;
            Debug.Log(deltaRange+" : DeltaRange");
        }
    }

    public void ChasePlayer()
    {
        Debug.Log("Chasing player......");
    }
}