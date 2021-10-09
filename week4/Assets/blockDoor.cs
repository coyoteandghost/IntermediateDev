using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockDoor : MonoBehaviour
{
    public bool hit;
    public GameObject collisionObj;

    // Start is called before the first frame update
    void Start()
    {
        hit = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject == collisionObj)
        {
            hit = true;
        } 
    } 


}



