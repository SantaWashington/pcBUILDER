using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rem_Cooler : MonoBehaviour
{
    public static string Cooler; // ќбъ€вление глобальной переменной
    public void Save_Cooler(string cooler)
    {
        string Cooler = cooler;
        PlayerPrefs.SetString("Cooler", Cooler);
    }
}
