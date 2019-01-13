using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardMaster : MonoBehaviour
{
    string key = "My First Key";
    private int value;
    public int curvalue;

    public void Start()
    {
        DontDestroyOnLoad(this);
    }
    public void Run()
    {
        value = gameObject.GetComponent<LevelGenerator>().EnemyPlus;
        
        curvalue += 2;
        Debug.Log(curvalue);
        PlayerPrefs.SetInt(key,value);
        
        //Debug.Log("Player Pref: "+ PlayerPrefs.GetInt(key).ToString());
    }




}