using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ControlState
{

    protected Animator animator;
    protected int velocityXHash;
    protected int velocityYHash;
    protected ControlManager controlManager;
    public static float levelOfBreathing = 100;

    public abstract void handleMovement();

    public void changeBreatheLevel(float value)
    {
        levelOfBreathing += value * Time.deltaTime;
    }

}
