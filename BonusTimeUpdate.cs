using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusTimeUpdate : MonoBehaviour {

    public Sprite Time_1;
    public Sprite Time_2;
    public TimeSetManager getTime;
    public float timeTemp = 0;
    public bool timeout;

    public GestureSourceManager getCombo;

    // Use this for initialization
    void Start () {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = Time_1;
    }
	
	// Update is called once per frame
	void Update () {

        if(getCombo.itemTime == true)
        {
            //timeTemp = getTime.timer + 10;
            //Debug.Log("TIME TEMP    ::::" + getCombo.timeTemp);
            //Debug.Log("TIMER        ::::" + getTime.timer);

            if (getCombo.timeTemp > getTime.timer)
            {
                Debug.Log("UPDATE BONUS TIME --- UPDATE BONUS TIME --- UPDATE BONUS TIME --- UPDATE BONUS TIME");
                timeout = false;
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Time_2;
            }
            else if (getCombo.timeTemp < getTime.timer)
            {
                //Debug.Log("UPDATE OUT BONUS TIME --- UPDATE OUT BONUS TIME --- UPDATE OUT BONUS TIME --- UPDATE OUT BONUS TIME");
                timeout = true;
                timeTemp = 0;
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Time_1;
            }
        }
        
        
        

	}
}
