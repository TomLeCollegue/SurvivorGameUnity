using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemperatureManager : MonoBehaviour
{


    public float temperaturePlayer = 30.0f;

    public ArrayList listVolume = new ArrayList();

    private void OnTriggerEnter(Collider volume)
    {


        Debug.Log("trigger");
        if (volume.GetComponent<DataVolume>())
        {
            DataVolume dataVolume = volume.GetComponent<DataVolume>();
            listVolume.Add(dataVolume);
        }
    }


    private void OnTriggerExit(Collider volume)
    {
        Debug.Log("TrigerExit");
        if (volume.GetComponent<DataVolume>())
        {
            DataVolume dataVolume = volume.GetComponent<DataVolume>();
            listVolume.Remove(dataVolume);
        }
    }

    private void Update()
    {
        if (listVolume.Count > 0)
        {
            temperaturePlayer = CalculTemp();
        }
        DataPlayer.singleton.warm = temperaturePlayer * 4;
    }


    private float CalculTemp()
    {
        float temp = -1000f;
        VolumeType volumeTypeMax = VolumeType.OUTSIDE;
        foreach (DataVolume dataVolume in listVolume)
        {
            if(dataVolume.volumeType.CompareTo(volumeTypeMax) >= 0)
            {
                temp = dataVolume.temperature;
                volumeTypeMax = dataVolume.volumeType;
            }
        }
        return temp;
    }
}
