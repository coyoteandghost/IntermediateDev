using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicTrigger : MonoBehaviour
{


    public GameObject switch1;
    public GameObject switch2;
    public GameObject switch3;
    public GameObject switch4;
    public GameObject switch5;
    public AudioSource mySource;
  

    // Start is called before the first frame update
 
    // Update is called once per frame
    void Update()
    {
        if (switch1.GetComponent<switches>().hit == true && switch2.GetComponent<switches>().hit == true && switch3.GetComponent<switches>().hit == true && switch4.GetComponent<switches>().hit == true && switch5.GetComponent<switches>().hit == true)
        {
            Destroy(gameObject);
            mySource.Play();
        }
    }
}
