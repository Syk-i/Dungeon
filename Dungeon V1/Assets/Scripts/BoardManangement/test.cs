using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : LevelGenerator {
    public int RoomNumber;
    public int one = 1;
    public int EnemyHealth;
    public int ShieldValue;
    // Use this for initialization

    private void Start()
    {
        //Delete();
        EnemyHealth = gameObject.GetComponent<Enemy>().health;
    }

    public void Awake()
    {
        RoomNumber = PlayerPrefs.GetInt("CurrentDungeon");
       RoomNumber += 1;
       // RoomNumber = 0;
        PlayerPrefs.SetInt("CurrentDungeon", RoomNumber); //set the new total value
        PlayerPrefs.Save();

        
        Debug.Log(RoomNumber);
        
        EnemyHealth += 1;
        Debug.Log(EnemyHealth);
        
    }
    public void Stats()
    {
      // ShieldValue= PlayerPrefs.GetInt("ShieldValue");
       // PlayerPrefs.SetInt("ShieldValue", 0);
    }

    void Delete()
    {
        PlayerPrefs.DeleteAll();
    }
}
