using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_object : MonoBehaviour
{
    public void Destroy(string nametag)
    {
        // Получаем все 3D объекты в сцене
        GameObject[] objects = GameObject.FindGameObjectsWithTag(nametag);

        // Удаляем каждый объект из списка
        foreach (GameObject obj in objects)
        {
            Destroy(obj);
        }
    }
    void Start()
    {
       
    }
}