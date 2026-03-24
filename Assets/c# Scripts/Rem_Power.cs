using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rem_Power : MonoBehaviour
{
    public static string Power_block; // ќбъ€вление глобальной переменной
    public void Save_Power(string p_block)
    {
        string Power_block = p_block;
        PlayerPrefs.SetString("Power", Power_block);
    }
}
