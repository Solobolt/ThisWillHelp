using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Goal : MonoBehaviour {
    public string sceneTitle = "MainMenu";

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //handles scene Loading
    public void LoadNextScene(string sceneTitle)
    {
        SceneManager.LoadScene(sceneTitle);
    }


    void OnTriggerEnter(Collider coll)
    {
        if(coll.gameObject.tag == "Player")
        {
            print("Player Collision with goal detected");
            if(SceneManager.GetActiveScene().buildIndex + 1 > SceneManager.sceneCount)
            {
                SceneManager.LoadScene("MainMenu");
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }
}
