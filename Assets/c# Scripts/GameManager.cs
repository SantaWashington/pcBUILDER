using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private GameObject selectedObject;
    private GameObject deletedObjectPrefab;
    private GameObject deletedObjectInstance;
    public GameObject SpawnPoint;
    public static string selectedObjectName;
    public static Vector3 selectedObjectPosition;

    // Метод для сохранения информации о выбранном объекте
    public void SaveSelectedObject(GameObject selectedObject)
    {
        this.selectedObject = selectedObject;
    }

    // Метод для получения информации о выбранном объекте
    public GameObject GetSelectedObject()
    {
        return selectedObject;
    }

    // Метод для сохранения информации о удаленном объекте
    public void SaveDeletedObjectState(string deletedObjectName)
    {
        PlayerPrefs.SetString("DeletedObject", deletedObjectName);
    }

    // Метод для получения информации о удаленном объекте
    public string GetDeletedObjectState()
    {
        return PlayerPrefs.GetString("DeletedObject", "");
    }
    public void RestoreDeletedObject()
    {
        // Проверяем, есть ли сохраненная информация о удаленном объекте
        string deletedObjectName = GetDeletedObjectState();
        if (!string.IsNullOrEmpty(deletedObjectName))
        {
            // Воссоздаем удаленный объект на сцене 1
            deletedObjectPrefab = Resources.Load<GameObject>(deletedObjectName);
            if (deletedObjectPrefab != null)
            {
                deletedObjectInstance = Instantiate(deletedObjectPrefab);
                deletedObjectInstance.transform.position = SpawnPoint.transform.position;
            }
        }
    }
    public static void SaveSelectedObject()
    {
        PlayerPrefs.SetString("selectedObjectName", selectedObjectName);
        PlayerPrefs.SetFloat("selectedObjectPositionX", selectedObjectPosition.x);
        PlayerPrefs.SetFloat("selectedObjectPositionY", selectedObjectPosition.y);
        PlayerPrefs.SetFloat("selectedObjectPositionZ", selectedObjectPosition.z);
        PlayerPrefs.Save();
    }

    // Загрузка информации о выбранном объекте
    public static void LoadSelectedObject()
    {
        selectedObjectName = PlayerPrefs.GetString("selectedObjectName", string.Empty);
        float positionX = PlayerPrefs.GetFloat("selectedObjectPositionX", 0f);
        float positionY = PlayerPrefs.GetFloat("selectedObjectPositionY", 0f);
        float positionZ = PlayerPrefs.GetFloat("selectedObjectPositionZ", 0f);
        selectedObjectPosition = new Vector3(positionX, positionY, positionZ);
    }
}