using UnityEngine;
using System.Collections;

public class UIManager : MonoBehaviour {

    public GameObject PauseMenu;
    public bool PauseActive;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (PauseActive)
        {
            if (PauseActive && Input.GetKeyDown(KeyCode.I))
            {
                PauseMenu.SetActive(false);
                PauseActive = false;
                Debug.Log("You have unpaused the game");
            }
        }
        else { 
            if(!PauseActive && Input.GetKeyDown(KeyCode.I))
            {
                PauseMenu.SetActive(true);
                PauseActive = true;
                Debug.Log("You have paused the game");
            }
        }
    }

    /*currently used by the "Resume" button in pause menu, but does not update PauseActive to False
      on the Panel - Pause Menu, so you have to hit "i" twice to get it to come back up. Not sure
      why this is happening?      
        */
    void resumeGame() 
    {
        PauseMenu.SetActive(false);
        PauseActive = false;
        Debug.Log("You have unpaused the game");
    }
}
