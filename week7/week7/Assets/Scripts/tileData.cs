using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tileData : MonoBehaviour
{
    public int tileSpeed;
    public int gridX;
    public int gridY;
    public AudioClip tileSound;
    public AudioSource mySource;
    int timer;
    public int timerMax;

    private void OnMouseDown() //when clicked on
    {
        Animator myAnim = gameObject.GetComponent<Animator>();

        Debug.Log(gridX + "," + gridY);
        Debug.Log(tileSound);

        myAnim.SetBool("clicked", true);

        mySource.clip = tileSound;
        mySource.Play();

       

    }

    private void Update()
    {
        Animator myAnim = gameObject.GetComponent<Animator>();
       
        if (myAnim.GetCurrentAnimatorStateInfo(0).IsName("tileanim") && myAnim.GetCurrentAnimatorStateInfo(0).normalizedTime > 1)
        {
            Destroy(gameObject);
        }


    }




}
