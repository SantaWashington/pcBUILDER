using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rememberproc : MonoBehaviour
{
    //public static Rememberproc Instance { get; private set; }
    //private void Awake()
    //{
    //    if (Instance == null)
    //    {
    //        Instance = this;
    //        DontDestroyOnLoad(gameObject);
    //    }
    //    else
    //    {
    //        Destroy(gameObject);
    //    }
    //}
    //public void SaveSavedObjectState(string savedObjectName)
    //{
    //    PlayerPrefs.SetString("SavedObject", savedObjectName);
    //    GameManager.selectedObjectName = savedObjectName;
    //}
    //public string GetSavedObjectState()
    //{
    //    return PlayerPrefs.GetString("SavedObject", "");
    //}
    public static Rememberproc Instance { get; private set; }
    private string savedObjectName;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SaveSavedObjectState(string savedObjectName)
    {
        this.savedObjectName = savedObjectName;
        PlayerPrefs.SetString("SavedObjectCPU", savedObjectName);
    }

    public string GetSavedObjectState()
    {
        return savedObjectName;
    }

    public void ClearSavedObjectState()
    {
        savedObjectName = null;
        PlayerPrefs.DeleteKey("SavedObjectCPU");
    }

    public void Reset()
    {
        ClearSavedObjectState();
        Destroy(gameObject);
    }
}