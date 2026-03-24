using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class New_spawn : MonoBehaviour
{
    //public GameObject[] objectsToSpawn; // Массив объектов для спавна

    //private GameObject selectedObject; // Выбранный объект для спавна
    //public GameObject SpawnPoint;
    //private GameObject savedObjectPrefab;
    //private GameObject savedObjectInstance;

    //public void SelectObject(int index)
    //{
    //    if (index >= 0 && index < objectsToSpawn.Length)
    //    {
    //        selectedObject = objectsToSpawn[index];
    //    }
    //}

    //public void SpawnSelectedObject()
    //{
    //    if (selectedObject != null)
    //    {
    //        Instantiate(selectedObject, SpawnPoint.transform.position, Quaternion.identity);
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
    //public void RestoreDeletedObject()
    //{


    //    //// Проверяем, есть ли сохраненная информация о удаленном объекте
    //    //string savedObjectName = GetSavedObjectState();
    //    //if (!string.IsNullOrEmpty(savedObjectName))
    //    //{

    //    //    // Воссоздаем удаленный объект на сцене 1
    //    //    savedObjectPrefab = Resources.Load<GameObject>(savedObjectName);

    //    //    if (savedObjectPrefab != null)
    //    //    {

    //    //        savedObjectInstance = Instantiate(savedObjectPrefab);
    //    //        savedObjectInstance.transform.position = SpawnPoint.transform.position;
    //    //        float scaleFactor = 0.1f; // Коэффициент уменьшения (измените значение по вашему усмотрению)
    //    //        savedObjectInstance.transform.localScale *= scaleFactor;
    //    //    }
    //    //}
    //}
    //public void ReturnToScene1()
    //{

    //    ObjectManager.objectDestroyed = false;
    //    SceneManager.LoadScene("Create_PC");

    //}
    //// Start is called before the first frame update
    //void Start()
    //{
    //    // Проверяем, есть ли сохраненная информация о удаленном объекте
    //    string savedObjectName = GetSavedObjectState();
    //    if (!string.IsNullOrEmpty(savedObjectName))
    //    {
    //        // Воссоздаем удаленный объект на сцене 1
    //        savedObjectPrefab = Resources.Load<GameObject>(savedObjectName);

    //        if (savedObjectPrefab != null)
    //        {
    //            savedObjectInstance = Instantiate(savedObjectPrefab);
    //            savedObjectInstance.transform.position = SpawnPoint.transform.position;
    //            float scaleFactor = 0.1f; // Коэффициент уменьшения (измените значение по вашему усмотрению)
    //            savedObjectInstance.transform.localScale *= scaleFactor;
    //        }
    //    }
    //}
    //---------------------------------------------------------------------------------------------------------------------------------------------------
    public GameObject[] objectsToSpawn; // Массив объектов для спавна
    private GameObject selectedObject; // Выбранный объект для спавна
   // public GameObject SpawnPoint;
    private GameObject savedObjectPrefab;
    private GameObject savedObjectInstance;
    private string selectedSpawnPoint;

    //void Start()
    //{
    //    // Получаем ссылку на SpawnPoint из SpawnPointManager
    //    Transform spawnPoint = SpawnPointManager.Instance.SpawnPoint;

    //    if (spawnPoint != null)
    //    {
    //        // Производим спавн объекта используя SpawnPoint
    //        Instantiate(selectedObject, spawnPoint.position, Quaternion.identity);
    //    }
    //    else
    //    {
    //        Debug.LogWarning("Spawn point is not set.");
    //    }
    //}
    public void SelectObject(int index)
    {
        if (index >= 0 && index < objectsToSpawn.Length)
        {
            selectedObject = objectsToSpawn[index];
        }
    }

    public void SpawnSelectedObject()
    {
        if (selectedObject != null)
        {
            Instantiate(selectedObject, SpawnPointManager.Instance.SpawnPoint.position, Quaternion.identity);
        }
    }

    public void SaveSavedObjectState(string savedObjectName)
    {
        PlayerPrefs.SetString("SavedObject", savedObjectName);
        GameManager.selectedObjectName = savedObjectName;
    }

    public string GetSavedObjectState()
    {
        return PlayerPrefs.GetString("SavedObject", "");
    }

    public void ReturnToScene1()
    {
        ObjectManager.objectDestroyed = false;
        SceneManager.LoadScene("Create_PC");
    }
    public void SaveSelectedSpawnPoint(string spawnPointName)
    {
        selectedSpawnPoint = spawnPointName;
        PlayerPrefs.SetString("SelectedSpawnPoint", spawnPointName);
    }
    public void SpawnCPU()
    {
        //// Проверяем, есть ли сохраненная информация о удаленном объекте
        //string savedObjectName = GetSavedObjectState();
        //if (!string.IsNullOrEmpty(savedObjectName))
        //{
        //    // Воссоздаем удаленный объект на сцене 1
        //    savedObjectPrefab = Resources.Load<GameObject>(savedObjectName);

        //    if (savedObjectPrefab != null)
        //    {
        //        if (savedObjectInstance != null)
        //        {
        //            Destroy(savedObjectInstance); // Удаляем предыдущий экземпляр объекта, если он существует
        //        }

        //        savedObjectInstance = Instantiate(savedObjectPrefab);
        //        savedObjectInstance.transform.position = SpawnPoint.transform.position;
        //        float scaleFactor = 0.1f; // Коэффициент уменьшения (измените значение по вашему усмотрению)
        //        savedObjectInstance.transform.localScale *= scaleFactor;
        //    }
        //}
        // Проверяем, есть ли сохраненная информация о удаленном объекте
        // Проверяем, есть ли сохраненная информация о удаленном объекте
        string savedObjectName = GetSavedObjectState();
        if (!string.IsNullOrEmpty(savedObjectName))
        {
            // Воссоздаем удаленный объект на сцене 1
            savedObjectPrefab = Resources.Load<GameObject>(savedObjectName);

            if (savedObjectPrefab != null)
            {
                if (savedObjectInstance != null)
                {
                    Destroy(savedObjectInstance); // Удаляем предыдущий экземпляр объекта, если он существует
                }

                if (SpawnPointManager.Instance.SpawnPoint != null)
                {
                    savedObjectInstance = Instantiate(savedObjectPrefab);
                    savedObjectInstance.transform.position = SpawnPointManager.Instance.SpawnPoint.position;
                    float scaleFactor = 0.1f; // Коэффициент уменьшения (измените значение по вашему усмотрению)
                    savedObjectInstance.transform.localScale *= scaleFactor;
                }
                else
                {
                    Debug.LogWarning("Spawn point is not set.");
                }
            }
        }
    }
    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {
        
    }
    private static New_spawn instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
