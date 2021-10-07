using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLAYERMOVEDUMBASS : MonoBehaviour
{
    public Rigidbody2D myBody;

    public float speed;
    public float dist;
    bool hasHit = false;
    


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mPos = Input.mousePosition;
        mPos = Camera.main.ScreenToWorldPoint(mPos);
        rotateSelf(mPos);

        if (Input.GetAxis("Vertical") > 0.1f) //input checks for any upwards input-- w, up arrow, up controller, etc. (0.1f is for sensitivity of input)
        {
            moveSelf(mPos);
        }
    }

    private void FixedUpdate()
    {
        Debug.DrawRay(transform.position, transform.right * dist, Color.red);
        if (Physics2D.Raycast(transform.position, transform.right, dist))
        {
            if (!hasHit)
            {
               // Debug.Log("hit something!");
                RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.right, dist); // logs the obj the raycast hits
                hit.transform.gameObject.GetComponent<Animator>().SetTrigger("doBounce");
                //musicMaker(hit.transform.gameObject); //applies hit obj to the music maker function
                hasHit = true;
            }
        }
        else
        {
            hasHit = false;
        }
    }



    /*
        void checkKeys()
        {
            if (Input.GetKey(KeyCode.W))
            {
                UDmove(speed);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                UDmove(-speed);
            }

            if (Input.GetKey(KeyCode.A))
            {
                LRmove(-speed);
                faceRight = false;
            }
            else if (Input.GetKey(KeyCode.D))
            {
                LRmove(speed);
                faceRight = true;
            }
        }



        void LRmove(float direction) //for movement left right
        {
            myBody.velocity = new Vector3(direction, myBody.velocity.y);
        }

        void UDmove(float direction) //for movement left right
        {
            myBody.velocity = new Vector3(myBody.velocity.x, direction);
        }
    */


    void rotateSelf(Vector3 mousePos)
    {
        //finding the difference between current facing direction and mouse position
        Vector2 direction = new Vector2(mousePos.x - transform.position.x, mousePos.y - transform.position.y);
        transform.right = direction;
    }

    void moveSelf(Vector3 mousePos)
    {
        mousePos = new Vector3(mousePos.x, mousePos.y, 0f); //keeps mouse position at the same depth
        float step = speed * Time.deltaTime; //makes speed frame-independent
        transform.position = Vector3.MoveTowards(transform.position, mousePos, step); // moving towards mouse position at speed step

    }


    /*
    void musicMaker(GameObject hit)
    {
        float volume = Vector3.Distance(hit.transform.position, transform.position);
        volume = 1f - (volume / 10f);
        mySource.volume = volume;
        AudioClip newClip = hit.GetComponent<Sound>().mySound; //gets variable from Sound script
        mySource.clip = newClip;
        mySource.Play();
    }
    */



}





