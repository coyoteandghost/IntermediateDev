using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballmove : MonoBehaviour
{

    public Rigidbody2D myBody;
    public float power;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) //if press space...
        {
            myBody.AddForce((Vector2.right) * power); //... add force to myBody's RigidBody
        }
    }
}
