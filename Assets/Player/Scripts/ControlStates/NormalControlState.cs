using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalControlState : ControlState
{
    public NormalControlState(Animator _animator, int _velocityYHash, int _velocityXHash, ControlManager _controlManager)
    {
        animator = _animator;
        velocityYHash = _velocityYHash;
        velocityXHash = _velocityXHash;
        controlManager = _controlManager;
        animator.SetLayerWeight(1, 1);
        animator.SetLayerWeight(2, 0);
    }

    public override void handleMovement()
    {
        float velocityX = Input.GetAxis("Horizontal");
        float velocityY = Input.GetAxis("Vertical");
        bool runPressed = Input.GetButton("LB") | Input.GetKey(KeyCode.LeftShift);

        if (runPressed && (velocityY!=0))
        {
            velocityY *= 2;
            velocityX *= 2;

            changeBreatheLevel(-15);
        }
        else if(DataPlayer.singleton.BreathingProgress < 100)
        {
            changeBreatheLevel(+20);
        }

        animator.SetFloat(velocityYHash, velocityY);
        animator.SetFloat(velocityXHash, velocityX);
        
        if(DataPlayer.singleton.BreathingProgress < 0)
        {
            controlManager.controlState = new BreathingState(animator, velocityYHash, velocityXHash, controlManager);
        }

    }
}
