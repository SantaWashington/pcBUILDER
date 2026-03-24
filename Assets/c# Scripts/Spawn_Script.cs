using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Script : MonoBehaviour
{
    public GameObject SpawnPoint;
    public GameObject ObjectToSpawn;

    public void Spawn_Object ()
    {
        //Instantiate(ObjectToSpawn, SpawnPoint.transform.position, Quaternion.identity);
        GameObject spawnedObject = Instantiate(ObjectToSpawn, SpawnPoint.transform.position, Quaternion.identity);

       
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
