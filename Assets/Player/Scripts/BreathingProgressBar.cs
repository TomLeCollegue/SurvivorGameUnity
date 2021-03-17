using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BreathingProgressBar : MonoBehaviour
{
    public Image image;
    
    // Update is called once per frame
    void Update()
    {
        image.fillAmount = ControlState.levelOfBreathing / 100;
    }
}
