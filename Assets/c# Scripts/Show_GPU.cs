using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Show_GPU : MonoBehaviour
{
    public Text gpu;
    public static string Text_gpu;

    void Update()
    {
        gpu.text = PlayerPrefs.GetString("GPU");
    }
}
