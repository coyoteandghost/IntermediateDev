using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemfloat : MonoBehaviour
{
    float delta = 0.1f;
    float speed = 1f;
    private Vector3 startPos;
    Rigidbody2D myBody;
    SpriteRenderer myRender;
    Vector3 initPos;

    // Start is called before the first frame update
    void Start()
    {
       
        startPos = transform.position;
      
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 v = startPos;
        v.y += delta * Mathf.Sin(Time.time * speed);
        transform.position = v;

    }
}
