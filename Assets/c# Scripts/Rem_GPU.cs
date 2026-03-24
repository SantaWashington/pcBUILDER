using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rem_GPU : MonoBehaviour
{
    public static string Power_GPU; // ќбъ€вление глобальной переменной
    public void Save_GPU(string p_gpu)
    {
        string Power_GPU = p_gpu;
        PlayerPrefs.SetString("GPU", Power_GPU);
    }
}
