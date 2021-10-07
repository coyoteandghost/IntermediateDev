using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switches : MonoBehaviour
{
    public bool hit;
    public float resetTimer;
    public float resetTimerMax;
    

    // Start is called before the first frame update
    void Start()
    {
        hit = false;

    }

    // Update is called once per frame
    void Update()
    {


        Debug.Log(hit);
        resetTimer += 1;

        if(resetTimer > resetTimerMax)
        {
            hit = false;
            resetTimer = 0;
            gameObject.GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f);
        }

        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "beam")
        {
            hit = true;
            resetTimer = 0;
            gameObject.GetComponent<SpriteRenderer>().material.color = new Color(1f, 0f, 0f);
        }
    }


}
