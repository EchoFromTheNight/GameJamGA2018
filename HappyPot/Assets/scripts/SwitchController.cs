using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchController : MonoBehaviour {

    //State of the switch
    public bool isOn;

    //External object that will be affected by the switch
    public GameObject externalObject;

    //SpriteOn
    public Sprite spriteOn;

    //SpriteOff
    public Sprite spriteOff;

    //Sprite Renderer
    private SpriteRenderer spriteRenderer;

    // Use this for initialization
    void Start ()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        updateSprite();
    }
	
	// Update is called once per frame
	void Update () {
    }

    private void OnMouseDown()
    {
        isOn = !isOn;
        ExternalAction script = externalObject.GetComponent<ExternalAction>();
        script.ExecuteAction(isOn);
        updateSprite();
    }   

    private void updateSprite()
    {
        if (isOn)
        {
            spriteRenderer.sprite = spriteOn;
        }
        else
        {
            spriteRenderer.sprite = spriteOff;
        }
    }
}
