using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {
    public int total;
    public int one = 1;
    public int enem;
    public int ShieldValue;
    // Use this for initialization

    private void Start()
    {
        //Delete();
    }

    public void Awake()
    {
        total = PlayerPrefs.GetInt("saved_total");
       total += one;
        //total = 0;
        PlayerPrefs.SetInt("saved_total", total); //set the new total value
        PlayerPrefs.Save();
        Debug.Log(total);
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
