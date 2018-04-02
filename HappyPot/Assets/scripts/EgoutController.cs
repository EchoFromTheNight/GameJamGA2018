using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EgoutController : MonoBehaviour
{

    //State of the switch
    private bool activated;

    //External object that will be affected.
    public GameObject externalObject;

    //AudioClip
    public AudioClip audioClip;

    //Reference to the AudioSource
    public AudioSource audioSource;

    //how long should we turn for.
    private float turnTime = 5f;

    // Use this for initialization
    void Start () {
        activated = false;
        audioSource.clip = audioClip;
    }
	
	// Update is called once per frame
	void Update () {
	}

    private void OnMouseDown()
    {
        if (!activated)
        {
            activated = true;
            audioSource.Play();
            StartCoroutine("Move");
        }
    }

    IEnumerator Move()
    {
        float timePassed = 0;
        while (timePassed < 5)
        {
            if (timePassed < 3)
            {
                transform.Translate(0.045f, 0, 0);
            }
            else if (timePassed < 5)
            {
                transform.Translate(0, -0.005f, 0);
                ExternalAction script = externalObject.GetComponent<ExternalAction>();
                script.ExecuteAction(activated);
            }
            timePassed += Time.deltaTime;
            yield return null;
        }
    }
}
