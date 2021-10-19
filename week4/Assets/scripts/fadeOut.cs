using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fadeOut : MonoBehaviour
{
    Color c;

 
    // Update is called once per frame
    void Update()
    {
        c = gameObject.GetComponent<SpriteRenderer>().color;
        c.a *= 1.1f;
        gameObject.GetComponent<SpriteRenderer>().color = c;
        Delete();
    }


    void Delete()
    {
        if (gameObject.GetComponent<SpriteRenderer>().color.a > 0.99)
        {
            SceneManager.LoadScene("endscene");
        }
    }

}
