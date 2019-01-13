using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    [Header("Grouping")]
    public GameObject TileGroup;
    public GameObject WallGroup;
    public GameObject EnemyGroup;
    public GameObject ChestGroup;
    public GameObject TrapDoorGroup;
    public bool generate;
    
   
   


    // Use this for initialization

    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
        if (generate == true)
        {
            foreach (Transform child in EnemyGroup.transform)
            {
                GameObject.Destroy(child.gameObject);
            }
            foreach (Transform child in WallGroup.transform)
            {
                GameObject.Destroy(child.gameObject);
            }
            foreach (Transform child in TileGroup.transform)
            {
                GameObject.Destroy(child.gameObject);
            }
            foreach (Transform child in TrapDoorGroup.transform)
            {
                GameObject.Destroy(child.gameObject);
            }
            foreach (Transform child in ChestGroup.transform)
            {
                GameObject.Destroy(child.gameObject);
            }

           
            SceneManager.GetActiveScene(); SceneManager.LoadScene("Gucci");
            
            
           
            generate = false;

            



        }
        
    }
    void Spawn()
    {
        if (generate == true)
        {

            for (int i = 0; i < gameObject.GetComponent<LevelGenerator>().tileAmount; i++)
            {

                StartCoroutine(gameObject.GetComponent<LevelGenerator>().GenerateLevel());



            }

        }
    }
}
   


