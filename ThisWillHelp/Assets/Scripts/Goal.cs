using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Goal : MonoBehaviour {
    public string sceneTitle = "MainMenu";

    private bool sceneMoved = false;

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
            if(SceneManager.GetActiveScene().buildIndex + 1 >= SceneManager.sceneCountInBuildSettings)
            {
                SceneManager.LoadScene("MainMenu");
            }
            else
            {
                if(sceneMoved == false)
                {
                    print("Index Number:" + (SceneManager.GetActiveScene().buildIndex + 1));
                    print("Scene Count:" + SceneManager.sceneCountInBuildSettings);
                    
                    //HealthController.totalHeath -= 0.075f;

                    sceneMoved = true;
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                }
                
            }
        }
    }
}
