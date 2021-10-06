using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beamBehavior : MonoBehaviour
{
    private float popTimer;
    public float popTimerMax;

    // Start is called before the first frame update
    void Start()
    {
        popTimer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        popTimer += 1;

        if(popTimer > popTimerMax)
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


}
