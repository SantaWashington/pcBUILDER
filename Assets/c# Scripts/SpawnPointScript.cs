using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPointScript : MonoBehaviour
{
    private void Awake()
    {
        // Присваиваем SpawnPoint в SpawnPointManager при загрузке сцены
        SpawnPointManager.Instance.SpawnPoint = transform;
    }
}
