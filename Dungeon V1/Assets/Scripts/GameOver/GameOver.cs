using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {
    public GameObject GameOverScreenOverlay;
    private int PlayerHealth;
	// Use this for initialization
	void Start () {
         // PlayerHealth = PlayerPrefs.GetInt("PlayerHealth");
	}
	
	// Update is called once per frame
	void Update () {
        PlayerHealth = PlayerPrefs.GetInt("PlayerHealth");
        if (PlayerHealth <= 0)
        {
            GameOverScreenOverlay.SetActive(true);
        }
        else
        {
            GameOverScreenOverlay.SetActive(false);
        }
	}
}
