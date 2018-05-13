using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelControl : MonoBehaviour {


    public Sprite easy;
    public Sprite normal;
    public Sprite hard;

    public bool easyState;
    public bool normalState = false;
    public bool hardState = false;


    private bool _inputLocked;
    public float inputlockingTime = 1f;


    // Use this for initialization
    void Start () {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = easy;
        easyState = true;
    }


    void UnlockInput()
    {
        _inputLocked = false;
    }
    void LockInput()
    {
        _inputLocked = true;
        Invoke("UnlockInput", inputlockingTime);
    }
    public bool isInputLocked()
    {
        return _inputLocked;
    }

    void Update()
    {
        //normalState = false;
        //hardState = false;

        if (Input.GetMouseButtonDown(1) && easyState == true)
        {
            if (isInputLocked())
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = normal;
                Debug.LogWarning("Input locked --- Normal");
                normalState = true;
                easyState = false;
                hardState = false;
            }

            else
            {
                Debug.Log("Hello!");
                LockInput();
            }
        }

        else if(Input.GetMouseButtonDown(1) && normalState == true)
        {
            if (isInputLocked())
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = hard;
                Debug.LogWarning("Input locked --- Hard");
                hardState = true;
                easyState = false;
                normalState = false;
            }

            else
            {
                Debug.Log("Hello!");
                LockInput();
            }
        }

        else if (Input.GetMouseButtonDown(1) && hardState == true)
        {
            if (isInputLocked())
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = easy;
                Debug.LogWarning("Input locked --- Easy");
                easyState = true;
                normalState = false;
                hardState = false;
            }

            else
            {
                Debug.Log("Hello!");
                LockInput();
            }
        }
    }

}
