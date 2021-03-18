using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreathingState : ControlState
{
    public BreathingState(Animator _animator, int _velocityYHash, int _velocityXHash, ControlManager _controlManager)
    {
        animator = _animator;
        velocityYHash = _velocityYHash;
        velocityXHash = _velocityXHash;
        controlManager = _controlManager;
        animator.SetLayerWeight(1, 0);
        animator.SetLayerWeight(2, 1);
    }

    public override void handleMovement()
    {
        float velocityX = Input.GetAxis("Horizontal");
        float velocityY = Input.GetAxis("Vertical");
        animator.SetFloat(velocityYHash, velocityY);
        animator.SetFloat(velocityXHash, velocityX); 
        
        changeBreatheLevel(+15);

        if (DataPlayer.singleton.BreathingProgress> 100)
        {
            controlManager.controlState = new NormalControlState(animator, velocityYHash, velocityXHash, controlManager);
        }
    }
}
