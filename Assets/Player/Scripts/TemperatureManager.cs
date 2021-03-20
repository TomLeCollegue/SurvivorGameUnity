using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemperatureManager : MonoBehaviour
{


    public float temperaturePlayer = 30.0f;
    public float backupTemp;

    private void OnTriggerEnter(Collider volume)
    {
        if (volume.GetComponent<DataVolume>())
        {
            backupTemp = temperaturePlayer;
            DataVolume dataVolume = volume.GetComponent<DataVolume>();
            temperaturePlayer = dataVolume.temperature;
        }
    
        if (volume.GetComponent<DataVolume>())
        {
            temperaturePlayer = backupTemp;
        }
    }



    private void Update()
    {
        DataPlayer.singleton.warm = temperaturePlayer * 4;
    }
}
