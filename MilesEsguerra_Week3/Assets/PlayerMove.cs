using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    public float jumpHeight;
    public float gravMultiplier;
    Rigidbody2D myBody;
    bool onFloor;
    SpriteRenderer myRender;
    SpriteRenderer biteRender;
    float biteTimer2;

    Vector3 spawnPos;

    public Sprite jumpSprite;
    public Sprite walkSprite;
    public Sprite standSprite;
    Animator walkAnim;
    Animator biteAnim;
    public GameObject bite;
    float biteTimer;
    bool biting;
    public float biteForce;
    public int RelicsCollected;

    public AudioSource audioData;
    public  AudioSource audioDataJump;
    public AudioSource audioDataBite;
    public AudioSource audioDataItem;
    public AudioSource BGmusic;
    public AudioSource audioDataDead;

    public GameObject winText;
    

    // Start is called before the first frame update
    void Start()
    {
        spawnPos = gameObject.transform.position;
        myBody = gameObject.GetComponent<Rigidbody2D>();
        myRender = gameObject.GetComponent<SpriteRenderer>();
        walkAnim = GetComponent<Animator>();
        audioData = GetComponent<AudioSource>();
        biteAnim = bite.GetComponent<Animator>();
        biteRender = bite.GetComponent<SpriteRenderer>();
        biteTimer = 0;
        BGmusic.Play();
        winText.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

        CheckKeys();
        if (onFloor && Input.GetKey(KeyCode.W)) 
        {
            onFloor = false;
        }

        if (!onFloor)
        {
            walkAnim.SetBool("isJumping", true);
        }

        if (onFloor)
        {
            walkAnim.SetBool("isJumping", false);
        }
        Debug.Log(biteTimer);

        if(RelicsCollected == 3)
        {
            winText.SetActive(true);
        }


    }

    void CheckKeys()
    {
        if (Input.GetKey(KeyCode.D)) //controller
        {
            //myRender.sprite = walkSprite;
            myRender.flipX = false;
            walkAnim.SetBool("isWalking", true);
            LRmove(speed);
            if (!audioData.isPlaying)
            {
                audioData.Play();
            }
        } 
        else if (Input.GetKey(KeyCode.A))
        {
            LRmove(-speed);
            walkAnim.SetBool("isWalking", true);
            //myRender.sprite = walkSprite;
            myRender.flipX = true;
            if (!audioData.isPlaying)
            {
                audioData.Play();
            }
        } else
        {
            walkAnim.SetBool("isWalking", false);
            audioData.Stop();
        }
        //----------
        if (Input.GetKey(KeyCode.W) && onFloor) //jump
        {
            myBody.velocity = new Vector3(myBody.velocity.x, jumpHeight);
            if (!audioDataJump.isPlaying)
            {
                audioDataJump.Play();
            }
        } 
        else if(!Input.GetKey(KeyCode.W) && !onFloor) //jump physics-- adding extra force over time throughout the jump. in this case, if going up, add the boost
        {
            myBody.velocity += Vector2.up * Physics2D.gravity.y * (jumpHeight - 1f) * Time.deltaTime; 
        } 
       
        //-----------------------
        if (Input.GetKey(KeyCode.Space) && biting == false)
        {
            biting = true;
            biteTimer2 = 1f;

            if (myRender.flipX == true)
            {
                biteAnim.SetBool("isBite", true);
            }
            else if (myRender.flipX == false)
            {
                biteAnim.SetBool("isBite", true);
            }

            if (!audioDataBite.isPlaying)
            {
                audioDataBite.Play();
            }

        }

        if (biteTimer2 == 1f)
        {
            biteTimer += 1f;
        }

        if (biteTimer > 8f)
        {
            biting = false;
            biteTimer = 0f;
            biteAnim.SetBool("isBite", false);
        }

        if (biteAnim.GetCurrentAnimatorStateInfo(0).IsName("biteanim") && myRender.flipX == false)
        {
            biteRender.flipX = false;
            bite.transform.position = new Vector3(gameObject.transform.position.x + 1, gameObject.transform.position.y);
            myBody.velocity += Vector2.right * speed *  (biteForce - 5f) * Time.deltaTime;
            walkAnim.SetBool("isWalking", true);
        }

        if (biteAnim.GetCurrentAnimatorStateInfo(0).IsName("biteanim") && myRender.flipX == true)
        {
            biteRender.flipX = true;
            bite.transform.position = new Vector3(gameObject.transform.position.x - 1, gameObject.transform.position.y);
            myBody.velocity += Vector2.left * speed * (biteForce - 5f) * Time.deltaTime;
            walkAnim.SetBool("isWalking", true);
        }


        if (biteAnim.GetCurrentAnimatorStateInfo(0).IsName("stillbite"))
        {
            bite.transform.position = new Vector3(-10, -10);
            //biteTimer2 = 0f;
        }


    }

    void jumpPhys()
    {
        if(myBody.velocity.y < 0)
        {
            myBody.velocity += Vector2.up * Physics2D.gravity.y * (gravMultiplier - 1f) * Time.deltaTime; // if going down, accelerate the grav force
        }
    }

    void LRmove(float direction) //for movement left right
    {
        myBody.velocity = new Vector3(direction, myBody.velocity.y);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "floor")
        {
            onFloor = true;
            walkAnim.SetBool("isJumping", false);
        } 

        if(collision.gameObject.tag == "enemy")
        {
            gameObject.transform.position = spawnPos;
            audioDataDead.Play();
           
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "pickup")
        {
            Destroy(collision.gameObject);
            RelicsCollected += 1;
            audioDataItem.Play();
        }
    }



}
