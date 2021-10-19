using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fadeIn : MonoBehaviour
{
    Color c; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       c = gameObject.GetComponent<SpriteRenderer>().color;
       c.a *= 0.9f;
       gameObject.GetComponent<SpriteRenderer>().color = c;
        Delete();
    }


    void Delete()
    {
        if(gameObject.GetComponent<SpriteRenderer>().color.a < 0.01)
        {
            Destroy(gameObject);
        }
    }

}
