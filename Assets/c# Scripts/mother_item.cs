using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mother_item : MonoBehaviour
{
    public Shop scriptShop;
    public string nameMotherItem;
    public string socketMother;

   

    public void Buy_mother ()
    {
        scriptShop.nameMotherItem = nameMotherItem;
        scriptShop.socketMother = socketMother;
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
