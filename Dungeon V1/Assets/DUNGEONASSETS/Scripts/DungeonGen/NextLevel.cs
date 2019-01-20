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
    public int enemi;
   
   


    // Use this for initialization

    void Start()
    {
        GameObject master = GameObject.Find("Master");
        test enemi = master.GetComponent<test>();
        
    }
    // Update is called once per frame
   // void Update()
   void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
           // SceneManager.GetActiveScene(); SceneManager.LoadScene("Gucci");
        }
        /*
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
            */
            
            
           
            
            
           
            generate = false;

            



        }
        
    }
   
   


