using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestInteract : CoinManager
{
    public GameObject coins;
    public int CoinsToGive;
    public GameObject Chest;

    public void Start()
    {
        //CoinsToGive= coins.GetComponent<CoinManager>().scoreValue;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            scoreValue = PlayerPrefs.GetInt("PlayerAmount");
            scoreValue += 2;
            GameObject.Destroy(Chest);
            PlayerPrefs.SetInt("PlayerCoinAmount", scoreValue);
            PlayerPrefs.Save();
            
        }
    }
}
