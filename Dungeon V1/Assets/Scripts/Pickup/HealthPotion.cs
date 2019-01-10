using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotion : MonoBehaviour
{
    public int HealthToGive;
    
    public void UseItem()
    {
        
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealthManager>().AidPlayer(HealthToGive);
        Debug.Log("Pressed");
        Destroy(gameObject);



    }
}
