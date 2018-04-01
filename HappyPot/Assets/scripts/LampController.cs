using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampController : ExternalAction {

    private SpriteRenderer spriteRenderer;

    //SpriteOn
    public Sprite lightOn;

    //SpriteOff
    public Sprite lightOff;

    //AudioClip
    public AudioClip audioClip;

    //Reference to the AudioSource
    public AudioSource audioSource;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = lightOff;
    }

    // Use this for initialization
    void Start () {
        audioSource.clip = audioClip;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public override void ExecuteAction(bool isOn)
    {
        //If switch is on
        if (isOn)
        {
            spriteRenderer.sprite = lightOn;
        }
        else   //if switch is off
        {
            spriteRenderer.sprite = lightOff;
        }
        audioSource.Play();
    }

}
