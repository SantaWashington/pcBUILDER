using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene_on3D : MonoBehaviour
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
    public void ReturnToSpawnScene()
    {
        Rememberproc.Instance.Reset();
        // Другие необходимые действия при возвращении на сцену
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
