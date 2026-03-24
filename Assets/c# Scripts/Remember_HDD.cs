using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Remember_HDD : MonoBehaviour
{
    public static Remember_HDD Instance { get; private set; }
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
        PlayerPrefs.SetString("SavedObjectMother", savedObjectName);
    }

    public string GetSavedObjectState()
    {
        return savedObjectName;
    }

    public void ClearSavedObjectState()
    {
        savedObjectName = null;
        PlayerPrefs.DeleteKey("SavedObjectMother");
    }

    public void Reset()
    {
        ClearSavedObjectState();
        Destroy(gameObject);
    }
}
