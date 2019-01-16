using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vendor : MonoBehaviour {
    int PlayerCoins;
	// Use this for initialization
	void Start () {

        
    }
	
	// Update is called once per frame
	public void BuyItem()
    {
        PlayerCoins = PlayerPrefs.GetInt("PlayerCoinAmount");
        PlayerCoins -= 1;
        PlayerPrefs.SetInt("PlayerCoinAmount",PlayerCoins);
        PlayerPrefs.Save();
    }
}
