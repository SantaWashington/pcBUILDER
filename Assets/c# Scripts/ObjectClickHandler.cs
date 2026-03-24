using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectClickHandler : MonoBehaviour
{
    private GameManager gameManager;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    private void OnMouseDown()
    {
        // Удаление объекта
        Destroy(gameObject);

        // Сохранение информации о его состоянии в GameManager
        gameManager.SaveDeletedObjectState(gameObject.name);
    }
}