using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Show_Power : MonoBehaviour
{
    public Text power;
    public static string Text_power;

    void Update()
    {
        power.text = PlayerPrefs.GetString("Power");
    }
}
