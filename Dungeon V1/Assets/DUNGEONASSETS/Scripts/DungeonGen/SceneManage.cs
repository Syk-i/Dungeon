using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;

public class SceneManage : MonoBehaviour
{
     void Start()
    {
        Scene newScene = UnityEngine.SceneManagement.SceneManager.CreateScene("My New Scene");

    }
   
}