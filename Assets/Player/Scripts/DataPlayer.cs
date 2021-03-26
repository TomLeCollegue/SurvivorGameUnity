using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataPlayer : MonoBehaviour
{
    public static DataPlayer singleton;
    public float BreathingProgress = 100f;
    public float health = 100f;
    public float temperatureFeeling = 100f;
    public float eat = 100f;

    public float LevelOfClothing = 100f;



    private void Start()
    {
        singleton = this;
    }
}
