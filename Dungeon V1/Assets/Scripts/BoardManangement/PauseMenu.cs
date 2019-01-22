using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {
    public bool isPaused;
    public GameObject pauseMenu;

     void Update()
    {
        if (isPaused)
        {
            pauseMenu.SetActive(true);
        }
        else
        {
            pauseMenu.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
        }
    }

    // Update is called once per frame
    public void Resume()
    {
        isPaused = false;
    }
}
