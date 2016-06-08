using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public Rigidbody rb;
    private Transform myTransform;

    private float speed = 10.0f;

    [SerializeField]
    private float xDirection;
    [SerializeField]
    private float yDirection;
 
	// Use this for initialization
	void Start () {
        myTransform = this.transform;
	}
	
	// Update is called once per frame
	void Update () {
        Controls();
        Move();
	}

    //Moves the player
    void Move()
    {
        rb.velocity = new Vector3(xDirection * speed,0,yDirection * speed);
    }

    //Registers player input
    void Controls() 
    {
        //handles key downs
        if(Input.GetKeyDown("w"))
        {
            print("Move Up");
            yDirection++;
        }

        if (Input.GetKeyDown("s"))
        {
            print("Move Down");
            yDirection--;
        }

        if (Input.GetKeyDown("d"))
        {
            print("Move Right");
            xDirection++;
        }

        if (Input.GetKeyDown("a"))
        {
            print("Move Left");
            xDirection--;
        }

        //handles key ups
        if (Input.GetKeyUp("w"))
        {
            print("Stop Move Up");
            yDirection--;
        }

        if (Input.GetKeyUp("s"))
        {
            print("Stop Move Down");
            yDirection++;
        }

        if (Input.GetKeyUp("d"))
        {
            print("Stop Move Right");
            xDirection--;
        }

        if (Input.GetKeyUp("a"))
        {
            print("Stop Move Left");
            xDirection++;
        }

        if(Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene(1);
            HealthController.totalHeath = 0.8f;
        }
    }
}
