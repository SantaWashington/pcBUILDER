using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    public static bool objectDestroyed = false;

    private static ObjectManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Эта строка предотвращает удаление объекта при загрузке другой сцены
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
