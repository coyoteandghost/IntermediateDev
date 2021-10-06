using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject beam;
    public float shootSpeed;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
       // playerDirection = player.GetComponent<playerMove>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject newBeam = Instantiate(beam, transform.position, transform.rotation);
            newBeam.transform.SetParent(gameObject.transform);
            newBeam.transform.localPosition = new Vector3(0.7f, 0);
 
            float dir = 0;
            /*if ()
            {
                newBeam.GetComponent<SpriteRenderer>().flipX = false;
                dir = 1;
            }
            else
            {
               newBeam.GetComponent<SpriteRenderer>().flipX = true;
                dir = -1;
            }
            */
            newBeam.GetComponent<Rigidbody2D>().velocity = new Vector3(gameObject.GetComponent<Rigidbody2D>().velocity.x + dir * shootSpeed, 0f);

        }


    }
}
