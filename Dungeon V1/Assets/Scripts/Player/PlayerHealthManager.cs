using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthManager : MonoBehaviour
{
    public int PlayerMaxHealth;
    public int playerCurrentHealth;

    public int numOfHearts;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;


    // Use this for initialization
    void Start()
    {
        playerCurrentHealth = PlayerMaxHealth;

    }

    // Update is called once per frame
    void Update()
    {
        if (playerCurrentHealth <=0)
        {
            gameObject.SetActive(false);
            Debug.Log("Working");


            
        }
    }

    public void HurtPlayer(int damageToGive)
    {
        playerCurrentHealth -= damageToGive;
        Debug.Log(damageToGive);
        Debug.Log(playerCurrentHealth);
        if (playerCurrentHealth > numOfHearts)
        {
            playerCurrentHealth = numOfHearts;
        }
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < playerCurrentHealth)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }
            if (i < numOfHearts)
            {
                hearts[i].enabled = true;

            }
            else
            {
                hearts[i].enabled = false;
            }

        }

    }
    public void SetMaxHealth()
    {
        playerCurrentHealth = PlayerMaxHealth;
    }
}

    
