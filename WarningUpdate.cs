using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarningUpdate : MonoBehaviour {

    public Sprite warning_1;
    public Sprite warning_2;

    public HeartRateUpdate getBPM;

    // Use this for initialization
    void Start () {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = warning_1;
    }
	
	// Update is called once per frame
	void Update () {
		
        if(getBPM.warning == true)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = warning_2;
        }
        else if(getBPM.warning == false)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = warning_1;
        }


	}
}
