using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataVolume : MonoBehaviour
{
    public float temperature = 20.0f;


    public VolumeType volumeType;

}

public enum VolumeType
{
    OUTSIDE = 0,
    INSIDE = 1,
    SOURCE = 2
}
