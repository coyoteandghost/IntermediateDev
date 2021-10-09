using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beamBehavior : MonoBehaviour
{
    private float popTimer;
    public float popTimerMax;
    public float force;
    Rigidbody2D myBody;
    

    // Start is called before the first frame update
    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
        popTimer = 0;

        Vector3 mPos = Input.mousePosition;
        mPos = Camera.main.ScreenToWorldPoint(mPos);
        Vector3 dir = new Vector2(mPos.x - transform.position.x, mPos.y - transform.position.y);

        myBody.AddForce(dir, ForceMode2D.Impulse);
    
    }

    // Update is called once per frame
    void Update()
    {
        popTimer += 1;
      
        if (popTimer > popTimerMax)
        {
            Destroy(gameObject);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }

    private void OnBecameInvisible()
    { 
        Destroy(gameObject);
    }


    void rotateForce(Vector3 mousePos)
    {
        //finding the difference between current facing direction and mouse position
        Vector2 direction = new Vector2(mousePos.x - transform.position.x, mousePos.y - transform.position.y);
        transform.right = direction;
    }

  
 }



