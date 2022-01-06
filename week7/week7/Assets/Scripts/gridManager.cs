using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class gridManager : MonoBehaviour
{
    public GameObject tilePrefab;

    public Sprite[] tileSprites;
 
    GameObject[,] gridTiles; //sets up 2d array COMMA IS IMPORTANT!!!

    public AudioClip[] tileChimes;

    public int gridWidth;
    public int gridHeight;

    // Start is called before the first frame update
    void Start()
    {
        gridTiles = new GameObject[gridWidth, gridHeight]; //setting up 10 spots in the x and y for the grid array

        for(int x = 0; x < gridWidth; x++) //looping
        {
            for(int y = 0; y < gridHeight; y++) // for loops in for loops... the program returns to the inner for loop FIRST until completion... THEN goes back to outer
            {
                MakeTile(x, y);
            }
        }

       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene(1);
        }
    }

    void MakeTile(int xPos, int yPos)
    {
        GameObject newTile = Instantiate(tilePrefab);

        int randTile = Random.Range(0, tileSprites.Length); //randomizes sprite
        newTile.GetComponent<SpriteRenderer>().sprite = tileSprites[randTile]; //sets sprite to random tile
        newTile.transform.position = new Vector3(transform.position.x + xPos, transform.position.y + yPos, 0);
        tileData myData = newTile.GetComponent<tileData>();

        if(randTile == 0)
        {
            newTile.GetComponent<tileData>().tileSound = tileChimes[0];
        } 
        
        else if(randTile == 1)
        {
            newTile.GetComponent<tileData>().tileSound = tileChimes[1];
        } 
        
        else if(randTile == 2)
        {
            newTile.GetComponent<tileData>().tileSound = tileChimes[2];
        }

        else if (randTile == 3)
        {
            newTile.GetComponent<tileData>().tileSound = tileChimes[3];
        }

        else if (randTile == 4)
        {
            newTile.GetComponent<tileData>().tileSound = tileChimes[4];
        }

        else if (randTile == 5)
        {
            newTile.GetComponent<tileData>().tileSound = tileChimes[5];
        }

        else if (randTile == 6)
        {
            newTile.GetComponent<tileData>().tileSound = tileChimes[6];
        }

        else if (randTile == 7)
        {
            newTile.GetComponent<tileData>().tileSound = tileChimes[7];
        }


        myData.gridX = xPos;
        myData.gridY = yPos;
        gridTiles[xPos, yPos] = newTile;
    }






}
