using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ControlState
{

    protected Animator animator;
    protected int velocityXHash;
    protected int velocityYHash;
    protected ControlManager controlManager;

    public abstract void handleMovement();

    public void changeBreatheLevel(float value)
    {
        DataPlayer.singleton.BreathingProgress += value * Time.deltaTime;
    }

}
