using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveChar(); // calls move funct
    }

    void MoveChar() //move funct
    {
        Vector3 newPos = transform.position; //sets the var to the current position
        if (Input.GetKey(KeyCode.UpArrow)) //if up key pressed...
        { 
            newPos.y += speed * Time.deltaTime; //add speed to the vert position
        }
        else if (Input.GetKey(KeyCode.DownArrow)) //if down pressed
        {
            newPos.y -= speed * Time.deltaTime; //subtract speed from the vert posiiton
        }else if (Input.GetKey(KeyCode.RightArrow)) //if right pressed
        {
            newPos.x += speed * Time.deltaTime; // add speed to the hori position
        }
        else if (Input.GetKey(KeyCode.LeftArrow)) //if left pressed
        {
            newPos.x -= speed * Time.deltaTime; //subtract speed from the hori position
        }
        transform.position = newPos; // set the current position to the new added/subtracted position (moving it over)
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        speed = collision.GetComponent<tileData>().tileSpeed;
    }

}




