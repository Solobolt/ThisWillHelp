using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Doors : MonoBehaviour {

    public GameObject[] doors;
    public GameObject goal;

    public Camera camera;
    public GameObject player;

	// Use this for initialization
	void Start () {
	    if(HealthController.totalHeath >= 1.0f)
        {
            for (int i = 0; i < doors.Length; i++)
            {
                doors[i].SetActive(false);
            }

            goal.SetActive(false);
        }
	}
	
	// Update is called once per frame
	void Update () {
	    if(player.transform.position.x >= 16.5f)
        {
            camera.gameObject.transform.parent = null;

            player.gameObject.GetComponent<PlayerController>().enabled = false;

            player.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(2.0f,0,0);

            if(player.gameObject.transform.position.x > 41.0f)
            {
                SceneManager.LoadScene("MainMenu");
            }
        }
	}
}
