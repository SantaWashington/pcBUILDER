using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotherSpawn : MonoBehaviour
{
    private GameObject savedObjectPrefab;
    private GameObject savedObjectInstance;
    public GameObject SpawnPoint;
    private RememberMother remembermother;

    private void Start()
    {
        remembermother = RememberMother.Instance;
        if (remembermother != null)
        {
            string savedObjectName = remembermother.GetSavedObjectState();
            if (!string.IsNullOrEmpty(savedObjectName))
            {
                
                savedObjectPrefab = Resources.Load<GameObject>(savedObjectName);

                if (savedObjectPrefab != null)
                {
                    GameObject[] objects3 = GameObject.FindGameObjectsWithTag("CPU");
                    if (objects3.Length > 0)
                    {
                        Debug.Log("процессор есть");
                        GameObject[] objects = GameObject.FindGameObjectsWithTag("E_CPU");
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
                    GameObject[] objects5 = GameObject.FindGameObjectsWithTag("Ram");
                    if (objects5.Length > 0)
                    {
                        Debug.Log("процессор есть");
                        GameObject[] objects = GameObject.FindGameObjectsWithTag("E_RAM");
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
                    savedObjectInstance = Instantiate(savedObjectPrefab);
                    savedObjectInstance.transform.position = SpawnPoint.transform.position;
                    float scaleFactor = 0.2f; // Коэффициент уменьшения (измените значение по вашему усмотрению)
                    savedObjectInstance.transform.localScale *= scaleFactor;
                    DontDestroyOnLoad(savedObjectInstance);
                    // Сбрасываем сохраненное имя объекта в Remembermother
                    remembermother.ClearSavedObjectState();
                    RememberMother.Instance.Reset();
                    GameObject[] objects2 = GameObject.FindGameObjectsWithTag("Mother");
                    if (objects2.Length > 0)
                    {
                        GameObject[] objects = GameObject.FindGameObjectsWithTag("E_Mother");
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
