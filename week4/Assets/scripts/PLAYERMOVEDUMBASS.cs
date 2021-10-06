using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLAYERMOVEDUMBASS : MonoBehaviour
{
    public float speed;
    public Rigidbody2D myBody;
    public static bool faceRight = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        checkKeys();
    }




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





}





