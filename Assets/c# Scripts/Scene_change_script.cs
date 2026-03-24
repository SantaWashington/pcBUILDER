using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_change_script : MonoBehaviour
{

    public GameObject layout;
    public void Change_scene (int numberScenes)
    {
        SceneManager.LoadScene(numberScenes);
        
    }
    

    public void Close_Buttons()
    {
        layout.gameObject.SetActive(false);
    }
    public void Show_Buttons()
    {
        layout.gameObject.SetActive(true);
    }
    public void Exit_Game()
    {
        Application.Quit();
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
