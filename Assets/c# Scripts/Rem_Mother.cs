using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rem_Mother : MonoBehaviour
{
    public static string Socket_Mother; // ќбъ€вление глобальной переменной
    public void Save_Mother(string s_mother)
    {
        string Socket_Mother = s_mother;
        PlayerPrefs.SetString("Mother", Socket_Mother);
    }

}
