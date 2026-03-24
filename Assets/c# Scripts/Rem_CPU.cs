using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rem_CPU : MonoBehaviour
{
     public static string Socket_CPU; // ќбъ€вление глобальной переменной
    public void Save_CPU(string s_cpu)
    {
        string Socket_CPU = s_cpu;
        PlayerPrefs.SetString("CPU", Socket_CPU);
    } 
}
