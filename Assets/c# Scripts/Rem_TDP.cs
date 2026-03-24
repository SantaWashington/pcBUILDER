using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rem_TDP : MonoBehaviour
{
    public static string TDP; // ќбъ€вление глобальной переменной
    public void Save_TDP(string tdp)
    {
        string TDP = tdp;
        PlayerPrefs.SetString("TDP", TDP);
    }
}
