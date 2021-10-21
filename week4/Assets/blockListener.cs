using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockListener : MonoBehaviour
{
    public GameObject switch1;
    public GameObject switch2;
    public GameObject switch3;
    public AudioSource mySource;
    public bool destroyed = false;

    public GameObject testSwitch1;
    public GameObject testSwitch2;
    public GameObject testSwitch3;
    public bool testDestroyed = false;


    // Update is called once per frame
    void Update()
    {
        MazePuzzle();
        FirstTest();


    }

    void MazePuzzle()
    {
        if (switch1.GetComponent<blockDoor>().hit == true &&
        switch2.GetComponent<blockDoor>().hit == true &&
        switch3.GetComponent<blockDoor>().hit == true &&
        destroyed == false)
        {
            destroyed = true;
            mySource.Play();
        }
    }

    void FirstTest()
    {
        if (testSwitch1.GetComponent<blockDoor>().hit == true &&
        testSwitch2.GetComponent<blockDoor>().hit == true &&
        testSwitch3.GetComponent<blockDoor>().hit == true &&
        testDestroyed == false)
        {
            testDestroyed = true;
            mySource.Play();
        }
    }



}


