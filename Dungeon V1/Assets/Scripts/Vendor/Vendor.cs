using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vendor : CoinManager {
    public  int PlayerCoins;
   
    
	// Use this for initialization
	void Start () {

        
    }
	
	// Update is called once per frame
	public void BuyItem()
    {
        Debug.Log("Pressed Vendor Button");
        PlayerCoins = PlayerPrefs.GetInt("PlayerCoinAmount");
        PlayerCoins = PlayerCoins - 1;
        Debug.Log(PlayerCoins);
        PlayerPrefs.SetInt("PlayerCoinAmount",PlayerCoins);
        PlayerPrefs.Save();
        SetScore();
        
    }
}
