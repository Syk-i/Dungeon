using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    public int health;
    public string enemyString;
    public int baseattack;
    public float moveSpeed;
    public int damageToGive;
    public GameObject coins;
   
    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
       
		
	}
    public void HurtEnemy(int thrust)
    {
        health -= thrust;
        Debug.Log(health);
        if (health <= 0)
        {
            Debug.Log("Dead");
           
            gameObject.SetActive(false);
            if(Random.Range(0,2)== 1)
            {
                Debug.Log("Coin");
               GameObject coin=  Instantiate(coins, transform.position, Quaternion.identity);
            }
        }
    }
    
}
