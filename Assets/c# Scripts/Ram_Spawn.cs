using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ram_Spawn : MonoBehaviour
{
    private GameObject savedObjectPrefab;
    private GameObject savedObjectInstance;
    public GameObject SpawnPoint;
    private Remember_RAM remember_ram;

    private void Start()
    {
        remember_ram = Remember_RAM.Instance;
        if (remember_ram != null)
        {
            string savedObjectName = remember_ram.GetSavedObjectState();
            if (!string.IsNullOrEmpty(savedObjectName))
            {
                GameObject[] objects3 = GameObject.FindGameObjectsWithTag("Mother");
                if (objects3.Length > 0)
                {
                    Debug.Log("процессор есть");
                    GameObject[] objects = GameObject.FindGameObjectsWithTag("E_Mother");
                    foreach (GameObject obj3 in objects)
                    {
                        Destroy(obj3);
                    }
                }
                GameObject[] objects4 = GameObject.FindGameObjectsWithTag("GPU");
                if (objects4.Length > 0)
                {
                    Debug.Log("процессор есть");
                    GameObject[] objects = GameObject.FindGameObjectsWithTag("E_GPU");
                    foreach (GameObject obj3 in objects)
                    {
                        Destroy(obj3);
                    }
                }
                GameObject[] objects5 = GameObject.FindGameObjectsWithTag("CPU");
                if (objects5.Length > 0)
                {
                    Debug.Log("процессор есть");
                    GameObject[] objects = GameObject.FindGameObjectsWithTag("E_CPU");
                    foreach (GameObject obj3 in objects)
                    {
                        Destroy(obj3);
                    }
                }
                GameObject[] objects6 = GameObject.FindGameObjectsWithTag("Power");
                if (objects6.Length > 0)
                {
                    Debug.Log("процессор есть");
                    GameObject[] objects = GameObject.FindGameObjectsWithTag("E_Power");
                    foreach (GameObject obj3 in objects)
                    {
                        Destroy(obj3);
                    }
                }
                GameObject[] objects7 = GameObject.FindGameObjectsWithTag("HDD_SSD");
                if (objects7.Length > 0)
                {
                    Debug.Log("процессор есть");
                    GameObject[] objects = GameObject.FindGameObjectsWithTag("E_HDD");
                    foreach (GameObject obj3 in objects)
                    {
                        Destroy(obj3);
                    }
                }
                GameObject[] objects8 = GameObject.FindGameObjectsWithTag("Cooler");
                if (objects8.Length > 0)
                {
                    Debug.Log("процессор есть");
                    GameObject[] objects = GameObject.FindGameObjectsWithTag("E_Cooler");
                    foreach (GameObject obj3 in objects)
                    {
                        Destroy(obj3);
                    }
                }
                savedObjectPrefab = Resources.Load<GameObject>(savedObjectName);

                if (savedObjectPrefab != null)
                {
                    savedObjectInstance = Instantiate(savedObjectPrefab);
                    savedObjectInstance.transform.position = SpawnPoint.transform.position;
                    float scaleFactor = 0.12f; // Коэффициент уменьшения (измените значение по вашему усмотрению)
                    savedObjectInstance.transform.localScale *= scaleFactor;
                    DontDestroyOnLoad(savedObjectInstance);
                    // Сбрасываем сохраненное имя объекта в Remembermother
                    remember_ram.ClearSavedObjectState();
                    Remember_RAM.Instance.Reset();
                    GameObject[] objects2 = GameObject.FindGameObjectsWithTag("Ram");
                    if (objects2.Length > 0)
                    {
                        GameObject[] objects = GameObject.FindGameObjectsWithTag("E_RAM");
                        foreach (GameObject obj in objects)
                        {
                            Destroy(obj);
                        }
                    }
                }
            }
        }
    }
}
