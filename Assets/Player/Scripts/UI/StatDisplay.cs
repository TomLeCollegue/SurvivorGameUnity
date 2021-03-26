using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StatDisplay : MonoBehaviour
{
    public TextMeshProUGUI meat;
    public TextMeshProUGUI temp;
    public TextMeshProUGUI health;

    // Update is called once per frame
    void Update()
    {
        meat.text = (DataPlayer.singleton.eat/10).ToString("0") ;
        temp.text = (DataPlayer.singleton.temperatureFeeling/10).ToString("0");
        health.text = (DataPlayer.singleton.health /10).ToString("0");
    }
}
