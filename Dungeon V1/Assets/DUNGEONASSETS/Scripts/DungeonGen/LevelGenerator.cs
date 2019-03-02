using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{

    [Header("Entities")]
    public GameObject Marker;
    public GameObject player;
    public GameObject enemy;
    public GameObject chest;
    public GameObject door;
    public GameObject ItemVendor;
    public GameObject ItemVendorMarker;
    public int chestAmount = 1;
    public int enemyAmount=10;

    [Header("UI")]
    private GameObject UIVanish;

    [Header("Tiles")]
    public GameObject[] tiles;
    public GameObject wall;

    public List<Vector3> createdTiles;

    public int tileAmount;
    public int tileSize; //space between each movement of the generator which will be 16 units
    public float waitTime;

    [Header("Probability")]
    public float chanceUp;
    public float chanceRight;
    public float chanceDown;
    //Wall Gen

    public float minY = 9999999;
    public float maxY = 0;

    public float minX = 9999999;
    public float maxX = 0;

    public float xAmount;
    public float yAmount;

    public float extraWallX;
    public float extraWallY;

    public int EnemyPlus;

    [Header("Grouping")]
    public  GameObject TileGroup;
    public GameObject WallGroup;
    public GameObject EnemyGroup;
    public GameObject ChestGroup;
    public GameObject TrapDoorGroup;
    int enemies;
    int EnemAmount;

     
    


    void Start()
    {
        //Debug.Log(gameObject.GetComponent<BoardMaster>().curvalue);

          
        
        StartCoroutine(GenerateLevel());
        //Random.seed = 10;// if you want to generate the same level again
        UIVanish = gameObject.GetComponent<Canvasui>().uidrop;
        //int EnemAmount = gameObject.GetComponent<test>().RoomNumber;
       // Debug.Log(EnemAmount);

    }

   public  IEnumerator GenerateLevel() //used for debugging
    {
        for (int i = 0; i < tileAmount; i++)
        {
            float dir = Random.Range(0f, 1f);
            int tile = Random.Range(0, tiles.Length);

            CreateTile(tile);
            CallMoveGen(dir);
            yield return new WaitForSeconds(waitTime);


            if (i == tileAmount - 1)
            {
                Finish();
            }
        }
        yield return 0;
    }



    void CallMoveGen(float ranDir)
    {
        if (ranDir < chanceUp)
        {
            MoveGen(0);

        }
        else if (ranDir < chanceRight)
        {
            MoveGen(1);
        }
        else if (ranDir < chanceDown)
        {
            MoveGen(2);
        }
        else
        {
            MoveGen(3);
        }
    }

    void MoveGen(int dir) //direction generator will mvoe
    {
        switch (dir)
        {
            case 0:
                transform.position = new Vector3(transform.position.x, transform.position.y + tileSize, 0);

                break;
            case 1:
                transform.position = new Vector3(transform.position.x + tileSize, transform.position.y, 0);

                break;
            case 2:
                transform.position = new Vector3(transform.position.x, transform.position.y - tileSize, 0);



                break;
            case 3:
                transform.position = new Vector3(transform.position.x - tileSize, transform.position.y, 0);

                break;
        }
    }


    public void CreateTile(int tileIndex)
    {
        if (!createdTiles.Contains(transform.position))
        {
            GameObject tileObject;

            tileObject = Instantiate(tiles[tileIndex], transform.position, transform.rotation) as GameObject;
            

            createdTiles.Add(tileObject.transform.position);
            for (int i = 0; i < tileAmount; i++)
            {
                tileObject.transform.parent = TileGroup.transform;
            }
        }
        else
        {
            tileAmount++;
        }


    }

    void Finish()
    {
        Debug.Log("All Floor Tiles are Spawned");
        CreateWallValues();
        CreateWalls();
        SpawnObjects();
        UIVanish.SetActive(false);
        
        
        
        
    }
    void SpawnObjects()
    {

        Debug.Log("SpawnObject Function running");
       
        GameObject Player =Instantiate(player, createdTiles[createdTiles.Count - 1], Quaternion.identity);
        Debug.Log("Player Position: "+ Player.transform.position);
        Marker.transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y, 0);
      Debug.Log("Marker:  " + Marker.transform.position);
        
        
        
       Marker.SetActive(true);

        Destroy(Player);
        for (int i = 0; i < 1; i++)
        {


            GameObject TrapDoor = Instantiate(door, createdTiles[0], Quaternion.identity);
            TrapDoor.transform.parent = TrapDoorGroup.transform;
        }
        for (int i = 0; i < 1; i++)
        {


            
            GameObject vendor = Instantiate(ItemVendorMarker, createdTiles[Random.Range(0, createdTiles.Count)], Quaternion.identity);
            Debug.Log("ItemVendor Position"+ vendor.transform.position);
            ItemVendor.transform.position = new Vector3(vendor.transform.position.x, vendor.transform.position.y, 0);
            Debug.Log("ItemVendor Marker: " + ItemVendor.transform.position);
            ItemVendor.SetActive(true);
            Destroy(vendor);

        }
        //door.transform.position = (createdTiles[0]);
        // TrapDoor.transform.parent = TrapDoorGroup.transform;
        //PlayerPrefs.GetInt("saved_total")
        for (int i = 0; i <enemyAmount ; i++)
        {
            GameObject Enemies= Instantiate(enemy, createdTiles[Random.Range(0, createdTiles.Count)], Quaternion.identity);
            //Spawns enemy at a random position within the dungeon
            Enemies.transform.parent = EnemyGroup.transform;
            //Places all enemy objects within an Enemy folder 
        }
        for (int i = 0; i < chestAmount; i++)
        {
           GameObject Chest = Instantiate(chest, createdTiles[Random.Range(0, createdTiles.Count)], Quaternion.identity);
            //Spawns chest at a random position within the dungeon 
            Chest.transform.parent = ChestGroup.transform;
            //Places all chest objects within a Chest folder
        }
    }

    void CreateWallValues()
    {
        for (int i = 0; i < createdTiles.Count; i++)
        {
            if (createdTiles[i].y < minY)
            {
                minY = createdTiles[i].y;
            }
            if (createdTiles[i].y > maxY)
            {
                maxY = createdTiles[i].y;
            }
            if (createdTiles[i].x < minX)
            {
                minX = createdTiles[i].x;
            }
            if (createdTiles[i].x > maxX)
            {
                maxX = createdTiles[i].x;
            }


            xAmount = ((maxX - minX) / tileSize) + extraWallX;
            yAmount = ((maxY - minY) / tileSize) + extraWallY;
        }

    }

    void CreateWalls()
    {
        for (int x = 0; x < xAmount; x++)
        {
            for (int y = 0; y < yAmount; y++)
            {
                if (!createdTiles.Contains(new Vector3((minX - (extraWallX * tileSize) / 2) + (x * tileSize), (minY - (extraWallY * tileSize) / 2) + (y * tileSize))))
                {
                    
                   GameObject Wall =  Instantiate(wall, new Vector3((minX - (extraWallX * tileSize) / 2) + (x * tileSize), (minY - (extraWallY * tileSize) / 2) + (y * tileSize)), transform.rotation);
                    Wall.transform.parent = WallGroup.transform;

                }
                }
            }
        }
   public  void DeleteWall()
    {
        {
            for (int x = 0; x < xAmount; x++)
            {
                for (int y = 0; y < yAmount; y++)
                {
                    
                        //GameObject Wall = Instantiate(wall, new Vector3((minX - (extraWallX * tileSize) / 2) + (x * tileSize), (minY - (extraWallY * tileSize) / 2) + (y * tileSize)), transform.rotation);
                        //Wall.transform.parent = WallGroup.transform;
                    Destroy(WallGroup);

                    
                }
            }
        }
    }

    public void DeleteTiles()
    {
        for (int i = 0; i < tileAmount; i++)
        {
            Destroy(TileGroup);
        }
    }

    public void DeleteEnemies()
    {
        for (int i = 0; i < enemyAmount; i++)
        {
            Destroy(EnemyGroup);
            
        }
        
    }
    public void DeleteSpawnables()
    {
        Destroy(ChestGroup);
        Destroy(TrapDoorGroup);
    }

       
    }

    
  

