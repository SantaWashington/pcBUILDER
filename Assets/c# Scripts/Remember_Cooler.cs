using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Remember_Cooler : MonoBehaviour
{
    public static Remember_Cooler Instance { get; private set; }
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
