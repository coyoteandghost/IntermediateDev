using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGmusic : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource mySource;

    private void Start()
    {
        mySource.Play();
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
