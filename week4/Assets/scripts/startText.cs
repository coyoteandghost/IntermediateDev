using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startText : MonoBehaviour
{
   


    private void Update()
    {
        if(FindObjectOfType<dialogueManager>().nextScreen1 == true)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }

}
