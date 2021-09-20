using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramovetryagain : MonoBehaviour
{
    public GameObject invisplatform;
    public float camMovenum;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /* private void OnCollisionEnter2D(Collision2D collision)  // Collision with obj moves camera to new point
     {
         Debug.Log("hit :)");
         if (collision.gameObject.name == "endingplatform")
         {
             Vector3 newCamPos = new Vector3(collision.gameObject.transform.position.x, collision.gameObject.transform.position.y, -10);
             Camera.main.transform.position = newCamPos;
         }
     }
    */

    private void OnTriggerEnter2D(Collider2D collision) //collision with invisible trigger moves camera to new point
    {
        if (collision.gameObject == invisplatform)
        {
            Vector3 newCamPos = new Vector3((collision.gameObject.transform.position.x * camMovenum), collision.gameObject.transform.position.y, -10);
            Camera.main.transform.position = newCamPos;
        }
    }

}
