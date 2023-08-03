using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Behaviour : StateMachineBehaviour
{
    
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetInteger("animationRepeatCount", animator.GetInteger("animationRepeatCount") - 1);
    }
}