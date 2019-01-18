using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinManager : MonoBehaviour
{
    public Text score;
    public int scoreValue = 0;
    int ScoreUpdate;
     void Update()
    {
        SetScore();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Coin")
        {
            scoreValue = PlayerPrefs.GetInt("PlayerCoinAmount");
            collision.gameObject.SetActive(false);
            scoreValue += 1;
            PlayerPrefs.SetInt("PlayerCoinAmount", scoreValue);
            // PlayerPrefs.DeleteKey("PlayerCoinAmount");
            PlayerPrefs.Save();
            
        }
    }
   public void SetScore()
    {
       
        score.text = PlayerPrefs.GetInt("PlayerCoinAmount").ToString();
    }




}