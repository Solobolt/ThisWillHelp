using UnityEngine;
using System.Collections;

public class Pill : MonoBehaviour {

    private GameManager gameManager;

	// Use this for initialization
	void Start () {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider coll)
    {
        print("Pill collition detected");
        if(coll.gameObject.tag == "Player")
        {
            gameManager.health = 0.2f;
            GameManager.totalHeath += 0.05f;
            Destroy(this.gameObject);
            print("Changed Health");
        }
    }
}
