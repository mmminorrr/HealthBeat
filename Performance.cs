using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Performance : MonoBehaviour {

    public Sprite begin_p;
    public Sprite perfect;
    public Sprite good;
    public Sprite wrong;

    public GestureSourceManager getPerform;
	// Use this for initialization
	void Start () {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = begin_p;
    }
	
	// Update is called once per frame
	void Update () {
		
        if(getPerform.scoreValue >= 20)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = perfect;
        }
        else if(getPerform.scoreValue >= 10 && getPerform.scoreValue < 20)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = good;
        }
        else if(getPerform.scoreValue < 10)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = wrong;
        }
        else
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = begin_p;
        }

	}
}
