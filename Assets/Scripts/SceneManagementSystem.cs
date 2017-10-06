using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneManagementSystem : MonoBehaviour {

    public string scene; //name of scene to be loaded - this needs to be set within the inspector in unity.
    private bool loadLock; //bool that prevents the scene from trying to be loaded more than once


    public void LoadScene(string scene)
    {
        //Debug.Log("You have clicked the button!");
        SceneManager.LoadScene(scene);
    }

    public void exitGame()
    {
        Debug.Log("you have quit the game!");
        Application.Quit();
    }
}

