using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class listener : MonoBehaviour
{
    public GameObject switch1;
    public GameObject switch2;
    public GameObject switch3;
    public GameObject switch4;
    public GameObject switch5;
    public AudioSource mySource;
    public bool destroyed = false;

    public GameObject testSwitch1;
    public GameObject testSwitch2;
    public GameObject testSwitch3;
    public bool testDestroyed = false;

    public GameObject musicswitch1;
    public GameObject musicswitch2;
    public GameObject musicswitch3;
    public GameObject musicswitch4;
    public GameObject musicswitch5;
    public bool musicDestroyed = false;


    // Update is called once per frame
    void Update()
    {
        MusicTestRoom();
        FirstTestRoom();
        MusicMazeRoom();
    }


    void MusicTestRoom()
    {
        if (switch1.GetComponent<switches>().hit == true
        && switch2.GetComponent<switches>().hit == true
        && switch3.GetComponent<switches>().hit == true
        && switch4.GetComponent<switches>().hit == true
        && switch5.GetComponent<switches>().hit == true
        && destroyed == false)
        {
            destroyed = true;
            mySource.Play();
        }

    }


    void FirstTestRoom()
    {
        if(testSwitch1.GetComponent<switches>().hit == true
        && testSwitch2.GetComponent<switches>().hit == true
        && testSwitch3.GetComponent<switches>().hit == true
        && testDestroyed == false)
        {
            testDestroyed = true;
            mySource.Play();
        }
    }

    void MusicMazeRoom()
    {
        if (musicswitch1.GetComponent<switches>().hit == true
       && musicswitch2.GetComponent<switches>().hit == true
       && musicswitch3.GetComponent<switches>().hit == true
       && musicswitch4.GetComponent<switches>().hit == true
       && musicswitch5.GetComponent<switches>().hit == true
       && musicDestroyed == false)
        {
            musicDestroyed = true;
            mySource.Play();
        }
    }


}




