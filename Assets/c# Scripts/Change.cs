using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Change : MonoBehaviour
{
    public int numberScenes;
    public string nametag;
    public void OnMouseDown()
    {

        Destroy(gameObject);
        // Получаем все 3D объекты в сцене
        GameObject[] objects = GameObject.FindGameObjectsWithTag(nametag);

        // Удаляем каждый объект из списка
        foreach (GameObject obj in objects)
        {
            Destroy(obj);
        }


        SceneManager.LoadScene(numberScenes);
    }
}
