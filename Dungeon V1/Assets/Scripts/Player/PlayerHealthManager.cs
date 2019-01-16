using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthManager : MonoBehaviour
{
    public int PlayerMaxHealth;
    public int playerCurrentHealth;
    

   // public int numOfHearts;

    //public Image[] hearts;
   // public Sprite fullHeart;
    //public Sprite emptyHeart;

    public Text health;
    


    // Use this for initialization
    void Start()
    {
        playerCurrentHealth = PlayerPrefs.GetInt("PlayerHealth");
        //playerCurrentHealth = PlayerMaxHealth;
        

    }

    // Update is called once per frame
    void Update()
    {
        
        if (playerCurrentHealth > PlayerMaxHealth)
        {
            playerCurrentHealth = PlayerMaxHealth;
        }
        

            if (playerCurrentHealth <=0)
        {
            gameObject.SetActive(false);
            Debug.Log("Working");


            
        }
        PlayerPrefs.SetInt("PlayerHealth", playerCurrentHealth);
        PlayerPrefs.Save();
        health.text = playerCurrentHealth.ToString();

    }

    public void HurtPlayer(int damageToGive)
    {
        playerCurrentHealth -= damageToGive;
        Debug.Log(damageToGive);
        Debug.Log(playerCurrentHealth);
       
        

    }
    public void SetMaxHealth()
    {
        playerCurrentHealth = PlayerMaxHealth;
    }

    public void AidPlayer(int HealthToGive)
    {
        
            playerCurrentHealth += HealthToGive;
            
        
    }
}

    
