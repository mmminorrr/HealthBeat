using UnityEngine;
using UnityEngine.UI;
using System.IO.Ports;
using System;

public class GetBPM : MonoBehaviour {
    public static string BMPtext;        
    Text text_bmp;
    public int bpmNum;
    public bool itemWarnning;
    
    SerialPort sp = new SerialPort("COM3", 9600);

    void Start()
    {
        sp.Open();
        sp.ReadTimeout = 1;
    }

    void Awake()
    {
        // Set up the reference.
        text_bmp = GetComponent<Text>();
        // Reset the score.
        //BMPtext = 0;
    }

    void Update()
    {
        if (sp.IsOpen)
        {
            try
            {
                BMPtext = sp.ReadLine();
                bpmNum = Convert.ToInt32(BMPtext);
                //BMPtext = sp.ReadByte();
                if(bpmNum > 10)
                {
                    //int i = 0;
                    Debug.Log("BMP:" + bpmNum);
                    text_bmp.text = "Heart rate ♥ :" + bpmNum;

                    //// Get the last bpmNum for analyst health information. ******
                    //// Send bpmNum into Analyst script on this action. ******

                    /*if(bpmNum > 100)
                    {
                        itemWarnning = true;
                    }
                    else if(bpmNum < 100)
                    {
                        itemWarnning = false;
                    }*/
                }

            }

            catch(System.Exception)
            {

            }
        }
    }

}
