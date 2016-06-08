using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MainMenu : MonoBehaviour {



	// Use this for initialization
	void Start () {
        HealthController.totalHeath = 0.8f;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //handles they play button function
    public void PlayGame()
    {
        SceneManager.LoadScene("TestingScene");
    }

    //handles closing the game
    public void QuitGame()
    {
        Application.Quit();
    }
}
