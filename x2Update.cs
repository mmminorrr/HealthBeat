using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class x2Update : MonoBehaviour {

    public Sprite x2_1;
    public Sprite x2_2;

    public GestureSourceManager getCombo;

    // Use this for initialization
    void Start () {

        this.gameObject.GetComponent<SpriteRenderer>().sprite = x2_1;
    }
	
	// Update is called once per frame
	void Update () {
		if(getCombo.itemx2 == true)
        {
            Debug.Log("UPDATE COMBO X2 ----- UPDATE COMBO X2 ----- UPDATE COMBO X2 ----- UPDATE COMBO X2");
            this.gameObject.GetComponent<SpriteRenderer>().sprite = x2_2;
        }
        else if(getCombo.itemx2 == false)
        {
            //Debug.Log("OUT OF UPDATE COMBO X2 ----- OUT OF UPDATE COMBO X2 ----- OUT OF UPDATE COMBO X2 ----- OUT OF UPDATE COMBO X2");
            this.gameObject.GetComponent<SpriteRenderer>().sprite = x2_1;
        }
	}
}
