using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroScript : MonoBehaviour {

    //AudioClip
    public AudioClip audioClip;

    //Reference to the AudioSource
    public AudioSource audioSource;

    private bool musicOn;

    public GameObject plant;

    public GameObject text;

    // Use this for initialization
    void Start()
    {
        audioSource.clip = audioClip;
        musicOn = false;
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown("space"))
        {
            if (!musicOn)
            {
                audioSource.Play();
                musicOn = !musicOn;
                plant.SetActive(false);
                text.SetActive(false);
                Camera cam = GetComponent<Camera>();
                cam.clearFlags = CameraClearFlags.SolidColor;
                cam.backgroundColor = Color.Lerp(Color.black, Color.black, 0);
            }
            else
            {
                SceneManager.LoadScene("Level_1", LoadSceneMode.Single);
            }
        }
    }
}
