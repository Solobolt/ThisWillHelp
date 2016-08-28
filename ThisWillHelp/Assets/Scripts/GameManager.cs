using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public bool showEffects = true;

    [Range(0.0f,1.0f)]
    public float health;

    public UnityStandardAssets.ImageEffects.Bloom bloom;
    public float bloomMax = 0.6f;

    public UnityStandardAssets.ImageEffects.Blur blur;
    public float blurMax = 3.0f;

    public UnityStandardAssets.ImageEffects.NoiseAndScratches noise;
    public float noiseMax = 0.8f;

    public AudioSource hospitalsfx;
    public float pitchMax = 0.8f;
    public float volumeMin = 0.86f;
    public float volumeMax = 2.0f;

    public GameObject camera;
    public float cameraSpeed = 10.0f;

	// Use this for initialization
	void Start () {
        print("bloom active");
        print("noise active");
        print("blur active");
	}
	
	// Update is called once per frame
	void Update () {
        if(showEffects == true)
        {
            bloom.bloomIntensity = (1.0f - health) * bloomMax;
            noise.grainIntensityMax = (1.0f - health) * noiseMax;
            blur.iterations = Mathf.FloorToInt((1.0f - health) * blurMax);
            hospitalsfx.pitch = (health) * pitchMax;
            hospitalsfx.volume = volumeMin + ((1.0f - health) * (volumeMax - volumeMin));

            if(health <= 0.21f)
            {
                camera.transform.rotation = Quaternion.Euler(90, camera.transform.rotation.eulerAngles.y + (cameraSpeed * Time.deltaTime), 0);
            }
        }
        else
        {
            bloom.bloomIntensity = 0;
            noise.grainIntensityMax = 0;
            blur.iterations = 0;
            hospitalsfx.pitch = 1.0f;
        }
	}

    
}
