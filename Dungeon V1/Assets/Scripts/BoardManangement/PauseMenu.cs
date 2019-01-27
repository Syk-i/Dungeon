using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {
    public bool isPaused;
    public GameObject pauseMenu;
    public GameObject player;
    public GameObject Enemy;

     void Update()
    {
        if (isPaused)
        {
            pauseMenu.SetActive(true);
            player.GetComponent<PlayerMovement>().myRigidbody.constraints = RigidbodyConstraints2D.FreezeAll;
            player.GetComponent<PlayerMovement>().animator.enabled = false;
            Enemy.GetComponent<DemonEnemy>().EnemyPause() ;
        }
        else
        {
            pauseMenu.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
            player.GetComponent<PlayerMovement>().animator.enabled = true;
            player.GetComponent<PlayerMovement>().myRigidbody.constraints = RigidbodyConstraints2D.FreezeRotation;

        }
    }

    // Update is called once per frame
    public void Resume()
    {
        isPaused = false;
        player.GetComponent<PlayerMovement>().animator.enabled = true;
        player.GetComponent<PlayerMovement>().myRigidbody.constraints = RigidbodyConstraints2D.None;
        player.GetComponent<PlayerMovement>().myRigidbody.constraints = RigidbodyConstraints2D.FreezeRotation;

    }
}
