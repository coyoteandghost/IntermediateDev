using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioBehavior : MonoBehaviour
{
    public AudioSource mySource;
    public float smackCount;
    public float smackCountMax;
    public GameObject lockedDoor;
    public float resetTimer;
    public float resetTimerMax;


    // Start is called before the first frame update
    void Start()
    {
        resetTimer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        resetTimer += 1;

        if(resetTimer > resetTimerMax)
        {
            smackCount = 0;
            resetTimer = 0;
        }

        if (smackCount == smackCountMax)
        {
            Destroy(lockedDoor);
        }
        


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "beam")
        {
            Debug.Log(smackCount);
            mySource.Play();
            smackCount += 1f;
        }
    }


}


