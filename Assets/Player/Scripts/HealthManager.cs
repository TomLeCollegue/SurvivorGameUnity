using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public float feelingTomuchHeat = 150f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(DataPlayer.singleton.temperatureFeeling >= feelingTomuchHeat)
        {
            TakeDamage(5f);
        }
    }

    private void TakeDamage(float value)
    {
        DataPlayer.singleton.health -= value * Time.deltaTime;
    }
}
