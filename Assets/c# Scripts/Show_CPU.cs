using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Show_CPU : MonoBehaviour
{
    public Text cpu;
    public static string Text_cpu;

    void Update()
    {
        cpu.text = PlayerPrefs.GetString("CPU");
    }
}
