using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchDoor : MonoBehaviour
{
    public GameObject switch1;
    public GameObject switch2;
    public GameObject switch3;
    public AudioSource mySource;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (switch1.GetComponent<switches>().hit == true && switch2.GetComponent<switches>().hit == true && switch3.GetComponent<switches>().hit == true)
        {
            mySource.Play();
            Destroy(gameObject);
        }
    }
}
