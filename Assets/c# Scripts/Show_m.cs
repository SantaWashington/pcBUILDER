using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Show_m : MonoBehaviour
{
    public Text mother;
    public static string Text_mother;
    
    void Update()
    {
        mother.text = PlayerPrefs.GetString("Mother");
    }

}
