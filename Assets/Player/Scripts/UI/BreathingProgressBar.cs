using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BreathingProgressBar : MonoBehaviour
{
    public Slider slider;
    
    // Update is called once per frame
    void Update()
    {
        slider.value = DataPlayer.singleton.BreathingProgress/ 100;
    }
}
