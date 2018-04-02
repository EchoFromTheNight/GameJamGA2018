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

    public GameObject spaceBar;

    // Use this for initialization
    void Start()
    {
        audioSource.clip = audioClip;
        musicOn = false;
        spaceBar.SetActive(false);
        StartCoroutine("ShowSpaceBar");
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
                spaceBar.SetActive(false);
                StartCoroutine("ShowSpaceBar");
            }
            else
            {
                SceneManager.LoadScene("Level_1", LoadSceneMode.Single);
            }
        }
    }

    IEnumerator ShowSpaceBar()
    {
        yield return new WaitForSeconds(5);
        spaceBar.SetActive(true);
    }
}
