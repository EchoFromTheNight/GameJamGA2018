using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEndController : MonoBehaviour {

    //AudioClip
    public AudioClip audioClip;

    //AudioClip
    public AudioClip audioClip2;

    //Reference to the AudioSource
    public AudioSource audioSource;

    //Reference to the AudioSource
    public AudioSource audioSource2;

    public GameObject animation1;

    public GameObject animation2;

    // Use this for initialization
    void Start() {
        audioSource.clip = audioClip;
        audioSource2.clip = audioClip2;
        animation2.SetActive(false);
        audioSource.Play();
        StartCoroutine("WaitAnimation1");
        audioSource2.Play();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator WaitAnimation1()
    {
        yield return new WaitForSeconds(4);
        animation1.SetActive(false);
        animation2.SetActive(true);
    }
}
