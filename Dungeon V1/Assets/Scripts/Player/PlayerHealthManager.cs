using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthManager : MonoBehaviour
{
    public int PlayerMaxHealth;
    public int playerCurrentHealth;
    public int Shieldvalue;

   // public int numOfHearts;

    //public Image[] hearts;
   // public Sprite fullHeart;
    //public Sprite emptyHeart;

    public Text health;
    public Text shield;


    // Use this for initialization
    void Start()
    {
        playerCurrentHealth = PlayerPrefs.GetInt("PlayerHealth");
        //playerCurrentHealth = PlayerMaxHealth;
        Shieldvalue = PlayerPrefs.GetInt("ShieldValue");

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
        playerCurrentHealth = 5; 
        PlayerPrefs.SetInt("PlayerHealth", playerCurrentHealth);
        PlayerPrefs.Save();
        health.text = playerCurrentHealth.ToString();
        Shieldvalue = PlayerPrefs.GetInt("ShieldValue");
        shield.text = Shieldvalue.ToString();

    }

    public void HurtPlayer(int damageToGive)
    {
        if(Shieldvalue <= 0)
        {
            playerCurrentHealth -= damageToGive;
            Debug.Log(damageToGive);
            Debug.Log(playerCurrentHealth);

        }
        else
        {
            Shieldvalue = PlayerPrefs.GetInt("ShieldValue");
            Shieldvalue -= damageToGive;
            PlayerPrefs.SetInt("ShieldValue", Shieldvalue);
            PlayerPrefs.Save();
            Debug.Log("ShieldCurrentHealth" + Shieldvalue);
            shield.text = Shieldvalue.ToString();
        }
        
       
        

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

    
