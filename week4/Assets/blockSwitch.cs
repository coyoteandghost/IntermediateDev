using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockSwitch : MonoBehaviour
{
    public GameObject switch1;
    public GameObject switch2;
    public GameObject switch3;
   
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log(switch1.GetComponent<blockDoor>().hit);


        if (switch1.GetComponent<blockDoor>().hit == true && 
           switch2.GetComponent<blockDoor>().hit == true && 
           switch3.GetComponent<blockDoor>().hit == true)
        {
            Destroy(gameObject);
            
        }
    }
}
