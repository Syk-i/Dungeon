using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TrapDoorInteract : NextLevel {

    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("Next Level");
            SceneManager.GetActiveScene(); SceneManager.LoadScene("Gucci");
        }
    }
}
