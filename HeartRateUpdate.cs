using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartRateUpdate : MonoBehaviour {

    public Sprite HP;
    public Sprite HP1;
    public Sprite HP2;
    public Sprite HP3;
    public Sprite HP4;
    public Sprite HP5;

    public GetBPM hp;
    public bool warning =false;

    void Start()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = HP;
    }

    void Update()
    {
        if(hp.bpmNum >= 50 && hp.bpmNum < 60)
        //if(hp.bpmNum >= 104 && hp.bpmNum < 114)
        {
            warning = false;
            this.gameObject.GetComponent<SpriteRenderer>().sprite = HP1;
        }

        else if(hp.bpmNum >= 60 && hp.bpmNum <= 70)
        //if(hp.bpmNum >= 114 && hp.bpmNum < 133)
        {
            warning = false;
            this.gameObject.GetComponent<SpriteRenderer>().sprite = HP2;
        }
        else if (hp.bpmNum > 70 && hp.bpmNum <= 80)
        //if(hp.bpmNum >= 133 && hp.bpmNum < 152)
        {
            warning = false;
            this.gameObject.GetComponent<SpriteRenderer>().sprite = HP3;
        }
        else if (hp.bpmNum > 80 && hp.bpmNum <= 90)
        //if(hp.bpmNum >= 152 && hp.bpmNum < 171)
        {
            warning = false;
            this.gameObject.GetComponent<SpriteRenderer>().sprite = HP4;
        }
        else if (hp.bpmNum > 90 && hp.bpmNum <= 100)
        //if(hp.bpmNum >= 171 && hp.bpmNum < 190)
        {
            warning = true;
            this.gameObject.GetComponent<SpriteRenderer>().sprite = HP5;
        }


    }
}
