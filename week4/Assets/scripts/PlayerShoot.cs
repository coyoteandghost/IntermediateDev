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

    //   playerDirection = player.GetComponent<playerMove>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mPos = Input.mousePosition;
        mPos = Camera.main.ScreenToWorldPoint(mPos);

        /*
        rotateSelf(mPos);
        orientShoot(mPos);
        */

        Vector3 aimDirection = (mPos - transform.position).normalized;
        float angle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject newBeam = Instantiate(beam, transform.position, transform.rotation);
            newBeam.transform.SetParent(gameObject.transform);
            newBeam.transform.eulerAngles = new Vector3(0, 0, angle);
            newBeam.transform.position = new Vector3(transform.position.x , transform.position.y, transform.position.z);
            newBeam.transform.parent = null;
            
            //newBeam.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, angle));
        }
        

    }

    void rotateSelf(Vector3 mousePos)
    {
        //finding the difference between current facing direction and mouse position
        Vector2 direction = new Vector2(mousePos.x - transform.position.x, mousePos.y - transform.position.y);
        transform.right = direction;
    }

    void orientShoot(Vector3 mousePos)
    {
        mousePos = new Vector3(mousePos.x, mousePos.y, 0f); //keeps mouse position at the same depth
        float step = shootSpeed * Time.deltaTime; //makes speed frame-independent
    }


}
