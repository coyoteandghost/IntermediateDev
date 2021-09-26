using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bitten : MonoBehaviour
{
    float delta = 2f;
    float speed = 0.3f;
    private Vector3 startPos;
    Rigidbody2D myBody;
    SpriteRenderer myRender;
    AudioSource enemyAudio;
    Vector3 initPos;

    // Start is called before the first frame update
    void Start()
    {
        initPos = transform.position;
        startPos = transform.position;
        myRender = GetComponent<SpriteRenderer>();
        enemyAudio = GetComponent<AudioSource>();
        myRender.flipX = true;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 v = startPos;
        v.x += delta * Mathf.Sin(Time.time * speed);
        transform.position = v;

        //Debug.Log(v.x);

        if (v.x > (initPos.x + 1.8))
        {
           myRender.flipX = false;
        }
        else if (v.x < (initPos.x - 1.8))
        {
          myRender.flipX = true;
        }

    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "bite")
        {
            enemyAudio.Play();
            Destroy(gameObject);
        }
    }

}
