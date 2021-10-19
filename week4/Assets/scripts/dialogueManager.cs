using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dialogueManager : MonoBehaviour
{

    public Text nameText;
    public Text dialogueText;

    public bool nextScreen1;

    public Animator animator;

    public Queue<string> sentences;

    public AudioSource mySource;

    // Start is called before the first frame update
    private void Start()
    {
        sentences = new Queue<string>();   
    }

    public void StartDialogue(dialogue dialogue)
    {
        animator.SetBool("isOpen", true);
        
        nameText.text = dialogue.name;

        sentences.Clear();

        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {

        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
        mySource.Play();

    }

    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach(char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }

    void EndDialogue()
    {
        animator.SetBool("isOpen", false);
        nextScreen1 = true;
    }


}
