using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotion : MonoBehaviour
{
    public int HealthToGive;
    public void UseItem()
    {
        Debug.Log("Pressed");
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealthManager>().AidPlayer(HealthToGive);
    }
}
