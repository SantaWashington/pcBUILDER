using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Show_Cooler : MonoBehaviour
{
    public Text cooler;
    public static string Text_cooler;

    void Update()
    {
        cooler.text = PlayerPrefs.GetString("Cooler");
    }
}
