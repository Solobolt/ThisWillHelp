using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public bool showEffects = true;

    [Range(0.0f,1.0f)]
    public float health;

    public UnityStandardAssets.ImageEffects.Bloom bloom;
    private float bloomMax = 0.6f;

    public UnityStandardAssets.ImageEffects.Blur blur;
    private float blurMax = 3.0f;

    public UnityStandardAssets.ImageEffects.NoiseAndScratches noise;
    private float noiseMax = 0.8f;

    public AudioSource hospitalsfx;
    private float pitchMax = 0.8f;
    private float volumeMin = 0.86f;
    private float volumeMax = 2.0f;


	// Use this for initialization
	void Start () {
        health = HealthController.totalHeath;
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
