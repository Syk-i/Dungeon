using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotion : MonoBehaviour
{
    public int HealthToGive;
    private Inventory inventory;
    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    public void UseItem()
    {
        
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealthManager>().AidPlayer(HealthToGive);
        Debug.Log("Pressed");
        Destroy(gameObject);
        for (int i = 0; i < inventory.slots.Length; i++)
        {
            inventory.isFull[i] = false;
            break;

        }


    }
}
