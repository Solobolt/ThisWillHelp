using UnityEngine;
using System.Collections;

public class Trap : MonoBehaviour {

    public GameObject pill;
    public GameObject targetLocation;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider coll)
    {
        if(coll.gameObject.tag == "Player")
        {
            if(pill.gameObject != null)
            {
                pill.transform.position = targetLocation.transform.position;
            }
        }
    }
}
