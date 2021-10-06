using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorOpen : MonoBehaviour
{
    public GameObject openedDoor;
    public GameObject keyPlacement;
    Vector3 newPos;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject == keyPlacement)
        {
             Destroy(openedDoor);
        }
    }

}
