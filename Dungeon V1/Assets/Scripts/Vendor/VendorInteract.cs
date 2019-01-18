using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class VendorInteract : MonoBehaviour {
    public GameObject ItemVendorPanelUI;
	// Use this for initialization
	void Start () {
        ItemVendorPanelUI.SetActive(false);
	}
	
	// Update is called once per frame
	
        void OnTriggerEnter2D(Collider2D other)
        {
        if (other.CompareTag("Player"))
        {
            ItemVendorPanelUI.SetActive(true);
            
        }
       
        }
        void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player"){
            ItemVendorPanelUI.SetActive(false);

        }
    }


}
