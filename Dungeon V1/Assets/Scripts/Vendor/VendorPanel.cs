﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class VendorPanel : CoinManager {
    public  int PlayerCoins;
    public GameObject itemButton;
    private Inventory inventory;
    public Text ShieldText;
    public int ShieldValue;
     

    // Use this for initialization
    void Start () {

        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }
	
	// Update is called once per frame
	public void BuyItem()
    {
        if (PlayerPrefs.GetInt("PlayerCoinAmount") > 0){
            Debug.Log("Pressed Vendor Button");
            PlayerCoins = PlayerPrefs.GetInt("PlayerCoinAmount");
            PlayerCoins = PlayerCoins - 1;
            Debug.Log(PlayerCoins);
            PlayerPrefs.SetInt("PlayerCoinAmount", PlayerCoins);
            PlayerPrefs.Save();
           // SetScore();
            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.isFull[i] == false)
                {

                    inventory.isFull[i] = true;
                    Instantiate(itemButton, inventory.slots[i].transform, false);
                    
                    break;
                }
            }


        }
        else
        {
            Debug.Log("Not enough money");
        }
        
        
    }
    public void BuyShield()
    {
        if (PlayerPrefs.GetInt("PlayerCoinAmount") > 0)
        {
            Debug.Log("Pressed Vendor Button");
            PlayerCoins = PlayerPrefs.GetInt("PlayerCoinAmount");
            PlayerCoins = PlayerCoins - 3;
            Debug.Log(PlayerCoins);
            PlayerPrefs.SetInt("PlayerCoinAmount", PlayerCoins);
            PlayerPrefs.Save();
            ShieldValue += 1;
            ShieldText.text = ShieldValue.ToString();
            
        }
        
    }
}
