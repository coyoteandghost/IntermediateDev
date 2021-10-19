using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogueTrigger : MonoBehaviour
{
    public dialogue dialogue;
    public GameObject player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject == player)
        {
            TriggerDialogue();
        }    
    }


    public void TriggerDialogue()
    {
        FindObjectOfType<dialogueManager>().StartDialogue(dialogue);
    }

}
