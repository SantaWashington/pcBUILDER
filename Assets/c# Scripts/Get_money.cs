using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Get_money : MonoBehaviour
{

    public static int Money;
    public Text moneyText;
    
    public void Plus_money()
    {
        Money++;
        PlayerPrefs.SetInt("Money", Money);
    }
    // Start is called before the first frame update
    void Start()
    {
        Money = PlayerPrefs.GetInt("Money", 0);
    }


}
