using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using Windows.Kinect;
using Microsoft.Kinect.VisualGestureBuilder;

public class GestureSourceManager : MonoBehaviour
{

    public struct EventArgs
    {
        public string name;
        public float confidence;

        public EventArgs(string _name, float _confidence)
        {
            name = _name;
            confidence = _confidence;
        }
    }

    public BodySourceManager _BodySource;
    public string databasePath;
    public string nameGesture;
    public TimeSetManager getTimer;
    public BonusTimeUpdate getTimeout;

    private KinectSensor _Sensor;
    private VisualGestureBuilderFrameSource _Source;
    private VisualGestureBuilderFrameReader _Reader;
    private VisualGestureBuilderDatabase _Database;
    private VisualGestureBuilderDatabase _Database1;
    private VisualGestureBuilderDatabase _Database2;
    private VisualGestureBuilderDatabase _Database3;
    private VisualGestureBuilderDatabase _Database4;
    private VisualGestureBuilderDatabase _Database5;
    private VisualGestureBuilderDatabase _Database6;
    private VisualGestureBuilderDatabase _Database7;
    private VisualGestureBuilderDatabase _Database8;
    private VisualGestureBuilderDatabase _Database9;
    private VisualGestureBuilderDatabase _Database10;
    private VisualGestureBuilderDatabase _Database11;
    private VisualGestureBuilderDatabase _Database12;
    private VisualGestureBuilderDatabase _Database13;
    private VisualGestureBuilderDatabase _Database14;
    private VisualGestureBuilderDatabase _Database15;
    private VisualGestureBuilderDatabase _Database16;
    private VisualGestureBuilderDatabase _Database17;
    private VisualGestureBuilderDatabase _Database18;
    private VisualGestureBuilderDatabase _Database19;
    private VisualGestureBuilderDatabase _Database20;
    private VisualGestureBuilderDatabase _Database21;
    private VisualGestureBuilderDatabase _Database22;
    private VisualGestureBuilderDatabase _Database23;
    private VisualGestureBuilderDatabase _Database24;
    private VisualGestureBuilderDatabase _Database25;
    private VisualGestureBuilderDatabase _Database26;
    private VisualGestureBuilderDatabase _Database27;
    private VisualGestureBuilderDatabase _Database28;
    private VisualGestureBuilderDatabase _Database29;

    public float scoreValue = 0;
    public int combo = 0;
    public bool itemx2,itemTime = false;
    public int countCombo = 0;
    public float countTime = 0;
    public float timeTemp=0;

    public bool loadScene = false;

    // Gesture Detection Events
    public delegate void GestureAction(EventArgs e);
    //public event GestureAction OnGesture;

    // Use this for initialization
    Text text;
    void Start()
    {
        _Sensor = KinectSensor.GetDefault();
        if (_Sensor != null)
        {

            if (!_Sensor.IsOpen)
            {
                _Sensor.Open();
            }

            // Set up Gesture Source
            _Source = VisualGestureBuilderFrameSource.Create(_Sensor, 0);

            // open the reader for the vgb frames
            _Reader = _Source.OpenReader();
            if (_Reader != null)
            {
                _Reader.IsPaused = true;
                _Reader.FrameArrived += GestureFrameArrived;
            }

            // load the gesture from the gesture database
            string path = System.IO.Path.Combine(Application.streamingAssetsPath, databasePath);
            _Database1 = VisualGestureBuilderDatabase.Create(path+"/Intro.gbd");
            _Database2 = VisualGestureBuilderDatabase.Create(path+ "/Onigiri.gbd");
            _Database3 = VisualGestureBuilderDatabase.Create(path + "/Move_on.gbd");
            _Database4 = VisualGestureBuilderDatabase.Create(path + "/Naja.gbd");
            _Database5 = VisualGestureBuilderDatabase.Create(path + "/Bangloey.gbd");
            _Database6 = VisualGestureBuilderDatabase.Create(path + "/Nidnid.gbd");
            _Database7 = VisualGestureBuilderDatabase.Create(path + "/ChoeyMoey.gbd");
            _Database8 = VisualGestureBuilderDatabase.Create(path + "/TakeUpArm.gbd");
            _Database9 = VisualGestureBuilderDatabase.Create(path + "/DrawBigHeart.gbd");
            _Database10 = VisualGestureBuilderDatabase.Create(path + "/Yeah.gbd");
            _Database11 = VisualGestureBuilderDatabase.Create(path + "/TourPai.gbd");
            _Database12 = VisualGestureBuilderDatabase.Create(path + "/Tummada.gbd");
            _Database13 = VisualGestureBuilderDatabase.Create(path + "/Move_down.gbd");
            _Database14 = VisualGestureBuilderDatabase.Create(path + "/Down_leg.gbd");
            _Database15 = VisualGestureBuilderDatabase.Create(path + "/LoveorNot.gbd");
            _Database16 = VisualGestureBuilderDatabase.Create(path + "/ComeOn.gbd");
            _Database17 = VisualGestureBuilderDatabase.Create(path + "/LetsCookie.gbd");
            _Database18 = VisualGestureBuilderDatabase.Create(path + "/Koisuru.gbd");
            _Database19 = VisualGestureBuilderDatabase.Create(path + "/FurtuneCookies.gbd");
            _Database20 = VisualGestureBuilderDatabase.Create(path + "/LetsWish.gbd");
            _Database21 = VisualGestureBuilderDatabase.Create(path + "/HenWing.gbd");
            _Database22 = VisualGestureBuilderDatabase.Create(path + "/Heyhey.gbd");
            _Database23 = VisualGestureBuilderDatabase.Create(path + "/Clap.gbd");
            _Database24 = VisualGestureBuilderDatabase.Create(path + "/Up_down.gbd");
            _Database25 = VisualGestureBuilderDatabase.Create(path + "/Hairoo.gbd");
            _Database26 = VisualGestureBuilderDatabase.Create(path + "/Rotate.gbd");
            _Database27 = VisualGestureBuilderDatabase.Create(path + "/End.gbd");
            _Database28 = VisualGestureBuilderDatabase.Create(path + "/Point.gbd");
            _Database29 = VisualGestureBuilderDatabase.Create(path + "/Side.gbd");


            // Load all gestures
            IList<Gesture> gesturesList1 = _Database1.AvailableGestures;
            IList<Gesture> gesturesList2 = _Database2.AvailableGestures;
            IList<Gesture> gesturesList3 = _Database3.AvailableGestures;
            IList<Gesture> gesturesList4 = _Database4.AvailableGestures;
            IList<Gesture> gesturesList5 = _Database5.AvailableGestures;
            IList<Gesture> gesturesList6 = _Database6.AvailableGestures;
            IList<Gesture> gesturesList7 = _Database7.AvailableGestures;
            IList<Gesture> gesturesList8 = _Database8.AvailableGestures;
            IList<Gesture> gesturesList9 = _Database9.AvailableGestures;
            IList<Gesture> gesturesList10 = _Database10.AvailableGestures;
            IList<Gesture> gesturesList11 = _Database11.AvailableGestures;
            IList<Gesture> gesturesList12 = _Database12.AvailableGestures;
            IList<Gesture> gesturesList13 = _Database13.AvailableGestures;
            IList<Gesture> gesturesList14 = _Database14.AvailableGestures;
            IList<Gesture> gesturesList15 = _Database15.AvailableGestures;
            IList<Gesture> gesturesList16 = _Database16.AvailableGestures;
            IList<Gesture> gesturesList17 = _Database17.AvailableGestures;
            IList<Gesture> gesturesList18 = _Database18.AvailableGestures;
            IList<Gesture> gesturesList19 = _Database19.AvailableGestures;
            IList<Gesture> gesturesList20 = _Database20.AvailableGestures;
            IList<Gesture> gesturesList21 = _Database21.AvailableGestures;
            IList<Gesture> gesturesList22 = _Database22.AvailableGestures;
            IList<Gesture> gesturesList23 = _Database23.AvailableGestures;
            IList<Gesture> gesturesList24 = _Database24.AvailableGestures;
            IList<Gesture> gesturesList25 = _Database25.AvailableGestures;
            IList<Gesture> gesturesList26 = _Database26.AvailableGestures;
            IList<Gesture> gesturesList27 = _Database27.AvailableGestures;
            IList<Gesture> gesturesList28 = _Database28.AvailableGestures;
            IList<Gesture> gesturesList29 = _Database29.AvailableGestures;


            for (int x = 0; x < gesturesList1.Count; x++)
            {
                Gesture g1 = gesturesList1[x];
                if(g1.Name.Equals("Intro_Right"))
                {
                    _Source.AddGesture(g1);
                }
                if (g1.Name.Equals("Intro_Left"))
                {
                    _Source.AddGesture(g1);
                }

            }

            for (int x = 0; x < gesturesList2.Count; x++)
            {
                Gesture g2 = gesturesList2[x];
                if (g2.Name.Equals("Onigiri_Right"))
                {
                    _Source.AddGesture(g2);
                }
                if (g2.Name.Equals("Onigiri_Left"))
                {
                    _Source.AddGesture(g2);
                }

            }

            for (int x = 0; x < gesturesList3.Count; x++)
            {
                Gesture g3 = gesturesList3[x];
                if (g3.Name.Equals("Move_on_Right"))
                {
                    _Source.AddGesture(g3);
                }
                if (g3.Name.Equals("Move_on_Left"))
                {
                    _Source.AddGesture(g3);
                }

            }

            for (int x = 0; x < gesturesList4.Count; x++)
            {
                Gesture g4 = gesturesList4[x];
                if (g4.Name.Equals("Naja"))
                {
                    _Source.AddGesture(g4);
                }

            }

            for(int x = 0; x < gesturesList5.Count; x++)
            {
                Gesture g5 = gesturesList5[x];
                if (g5.Name.Equals("Bangloey"))
                {
                    _Source.AddGesture(g5);
                }
            }

            for (int x = 0; x < gesturesList6.Count; x++)
            {
                Gesture g6 = gesturesList6[x];
                if (g6.Name.Equals("Nidnid"))
                {
                    _Source.AddGesture(g6);
                }
            }

            for (int x = 0; x < gesturesList7.Count; x++)
            {
                Gesture g7 = gesturesList7[x];
                if (g7.Name.Equals("ChoeyMoey"))
                {
                    _Source.AddGesture(g7);
                }
            }

            for (int x = 0; x < gesturesList8.Count; x++)
            {
                Gesture g8 = gesturesList8[x];
                if (g8.Name.Equals("TakeUpArm_Right"))
                {
                    _Source.AddGesture(g8);
                }
                if (g8.Name.Equals("TakeUpArm_Left"))
                {
                    _Source.AddGesture(g8);
                }
            }

            for (int x = 0; x < gesturesList9.Count; x++)
            {
                Gesture g9 = gesturesList9[x];
                if (g9.Name.Equals("DrawBigHeart"))
                {
                    _Source.AddGesture(g9);
                }
            }

            for (int x = 0; x < gesturesList10.Count; x++)
            {
                Gesture g10 = gesturesList10[x];
                if (g10.Name.Equals("Yeah"))
                {
                    _Source.AddGesture(g10);
                }
            }

            for (int x = 0; x < gesturesList11.Count; x++)
            {
                Gesture g11 = gesturesList11[x];
                if (g11.Name.Equals("TourPai"))
                { 
                    _Source.AddGesture(g11);
                }
            }

            for (int x = 0; x < gesturesList12.Count; x++)
            {
                Gesture g12 = gesturesList12[x];
                if (g12.Name.Equals("Tummada"))
                {
                    _Source.AddGesture(g12);
                }
            }

            for (int x = 0; x < gesturesList13.Count; x++)
            {
                Gesture g13 = gesturesList13[x];
                if (g13.Name.Equals("Move_down_Left"))
                {
                    _Source.AddGesture(g13);
                }
                if (g13.Name.Equals("Move_down_Right"))
                {
                    _Source.AddGesture(g13);
                }

            }

            for (int x = 0; x < gesturesList14.Count; x++)
            {
                Gesture g14 = gesturesList14[x];
                if (g14.Name.Equals("Down_leg_Left"))
                {
                    _Source.AddGesture(g14);
                }
                if (g14.Name.Equals("Down_leg_Right"))
                {
                    _Source.AddGesture(g14);
                }

            }

            for (int x = 0; x < gesturesList15.Count; x++)
            {
                Gesture g15 = gesturesList15[x];
                if (g15.Name.Equals("LoveorNot_Left"))
                {
                    _Source.AddGesture(g15);
                }

            }

            for (int x = 0; x < gesturesList16.Count; x++)
            {
                Gesture g16 = gesturesList16[x];
                if (g16.Name.Equals("ComeOn"))
                {
                    _Source.AddGesture(g16);
                }

            }

            for (int x = 0; x < gesturesList17.Count; x++)
            {
                Gesture g17 = gesturesList17[x];
                if (g17.Name.Equals("LetsCookie"))
                {
                    _Source.AddGesture(g17);
                }

            }

            for (int x = 0; x < gesturesList18.Count; x++)
            {
                Gesture g18 = gesturesList18[x];
                if (g18.Name.Equals("Koisuru_Left"))
                {
                    _Source.AddGesture(g18);
                }
                if (g18.Name.Equals("Koisuru_Right"))
                {
                    _Source.AddGesture(g18);
                }
            }

            for (int x = 0; x < gesturesList19.Count; x++)
            {
                Gesture g19 = gesturesList19[x];
                if (g19.Name.Equals("FurtuneCookies"))
                {
                    _Source.AddGesture(g19);
                }
            }

            for (int x = 0; x < gesturesList20.Count; x++)
            {
                Gesture g20 = gesturesList20[x];
                if (g20.Name.Equals("LetsWish_Left"))
                {
                    _Source.AddGesture(g20);
                }
                if (g20.Name.Equals("LetsWish_Right"))
                {
                    _Source.AddGesture(g20);
                }
            }

            for (int x = 0; x < gesturesList21.Count; x++)
            {
                Gesture g21 = gesturesList21[x];
                if (g21.Name.Equals("HenWing"))
                {
                    _Source.AddGesture(g21);
                }
            }

            for (int x = 0; x < gesturesList22.Count; x++)
            {
                Gesture g22 = gesturesList22[x];
                if (g22.Name.Equals("Heyhey"))
                {
                    _Source.AddGesture(g22);
                }
            }

            for (int x = 0; x < gesturesList23.Count; x++)
            {
                Gesture g23 = gesturesList23[x];
                if (g23.Name.Equals("Clap"))
                {
                    _Source.AddGesture(g23);
                }
            }

            for (int x = 0; x < gesturesList24.Count; x++)
            {
                Gesture g24 = gesturesList24[x];
                if (g24.Name.Equals("Up_down"))
                {
                    _Source.AddGesture(g24);
                }
            }

            for (int x = 0; x < gesturesList25.Count; x++)
            {
                Gesture g25 = gesturesList25[x];
                if (g25.Name.Equals("Hairoo"))
                {
                    _Source.AddGesture(g25);
                }
            }

            for (int x = 0; x < gesturesList26.Count; x++)
            {
                Gesture g26 = gesturesList26[x];
                if (g26.Name.Equals("Rotate"))
                {
                    _Source.AddGesture(g26);
                }
            }

            for (int x = 0; x < gesturesList27.Count; x++)
            {
                Gesture g27 = gesturesList27[x];
                if (g27.Name.Equals("End"))
                {
                    _Source.AddGesture(g27);
                }
            }

            for (int x = 0; x < gesturesList28.Count; x++)
            {
                Gesture g28 = gesturesList28[x];
                if (g28.Name.Equals("Point_Left"))
                {
                    _Source.AddGesture(g28);
                }
                if (g28.Name.Equals("Point_Right"))
                {
                    _Source.AddGesture(g28);
                }
            }

            for (int x = 0; x < gesturesList29.Count; x++)
            {
                Gesture g29 = gesturesList29[x];
                if (g29.Name.Equals("Side"))
                {
                    _Source.AddGesture(g29);
                }
            }
        }
    }

    // Public setter for Body ID to track
    public void SetBody(ulong id)
    {
        if (id > 0)
        {
            _Source.TrackingId = id;
            _Reader.IsPaused = false;
        }
        else
        {
            _Source.TrackingId = 0;
            _Reader.IsPaused = true;
        }
    }

    // Update Loop, set body if we need one
    void Update()
    {
        if (!_Source.IsTrackingIdValid)
        {
            FindValidBody();
        }

    }

    // Check Body Manager, grab first valid body
    void FindValidBody()
    {

        if (_BodySource != null)
        {
            //Debug.Log("Body source != null");
            Body[] bodies = _BodySource.GetData();
            if (bodies != null)
            {
                //Debug.Log("bodies != null");
                foreach (Body body in bodies)
                {
                    if (body.IsTracked)
                    {
                        //Debug.Log("!!!!!!!!!!!!! Is Tracked !!!!!!!!!!");
                        SetBody(body.TrackingId);
                        break;
                    }
                }
            }
        }

    }

    /// Handles gesture detection results arriving from the sensor for the associated body tracking Id
    public void GestureFrameArrived(object sender, VisualGestureBuilderFrameArrivedEventArgs e)
    {
        //Debug.Log("GestureFrameArrived CALLED!");
        VisualGestureBuilderFrameReference frameReference = e.FrameReference;
        using (VisualGestureBuilderFrame frame = frameReference.AcquireFrame())
        {
            //Debug.Log("frame: "+ frame);
            if (frame != null)
            {
                //Debug.Log("frame != null");
                // get the discrete gesture results which arrived with the latest frame
                IDictionary<Gesture, DiscreteGestureResult> discreteResults = frame.DiscreteGestureResults;

                if (discreteResults != null)
                {
                    //Debug.Log("discreteResults != null");
                    foreach (Gesture gesture in _Source.Gestures)
                    {
                        if (gesture.GestureType == GestureType.Discrete)
                        {
                            //Debug.Log("G:" + gesture.Name);
                            DiscreteGestureResult result = null;
                            discreteResults.TryGetValue(gesture, out result);

                            if (result != null && (result.Confidence > 0))
                            {
                                // Fire Event
                                //OnGesture(new EventArgs(gesture.Name, result.Confidence));
                                //Debug.Log("Detected Gesture " + gesture.Name + " with Confidence " + result.Confidence);
                                //scoreValue = result.Confidence * 100;
                                //Scoreup.score += scoreValue;
                                //Debug.Log("SCORE:" + Scoreup.score);
                                //scoreValue += result.Confidence*100;
                                //text.text = "SCORE: " + scoreValue;

                                //nameGesture = gesture.Name;
                                //check = result.Confidence;

                                //////////////////////////////////////////////// INTRO SET
                                if (((getTimer.timer <= 0.831995) || (getTimer.timer > 2.197324 && getTimer.timer <= 3.370658) ||
                                    (getTimer.timer > 4.053311 && getTimer.timer <= 5.077324) || (getTimer.timer > 6.527982 && getTimer.timer <= 7.274649))
                                    && (gesture.Name.Equals("Intro_Left")))
                                {
                                    Debug.Log("TIME SET 1.1:" + getTimer.timer + "Confidence :" + result.Confidence);
                                    scoreValue = result.Confidence * 100;
                                }
                                else if (((getTimer.timer > 0.831995 && getTimer.timer <= 2.197324) || (getTimer.timer > 3.370658 && getTimer.timer <= 4.053311)
                                    || (getTimer.timer > 5.077324 && getTimer.timer <= 6.527982) || (getTimer.timer > 7.274649 && getTimer.timer <= 8.405329))
                                    && (gesture.Name.Equals("Intro_Right")))
                                {
                                    Debug.Log("TIME SET 1.2:" + getTimer.timer + "Confidence :" + result.Confidence);
                                    scoreValue = result.Confidence * 100;
                                }

                                //////////////////////////////////////////////// Onigiri SET
                                else if (((getTimer.timer > 8.405329 && getTimer.timer <= 10.60265) || (getTimer.timer > 12.65066 && getTimer.timer <= 14.52798)
                                    || (getTimer.timer > 270.784 && getTimer.timer <= 272.6187) || (getTimer.timer > 274.9653 && getTimer.timer <= 275.2))
                                    && (gesture.Name.Equals("Onigiri_Left")))
                                {
                                    Debug.Log("TIME SET 2.1:" + getTimer.timer + "Confidence :" + result.Confidence);
                                    scoreValue = result.Confidence * 100;
                                }
                                else if (((getTimer.timer > 10.60265 && getTimer.timer <= 12.65066) || (getTimer.timer > 14.52798 && getTimer.timer <= 16.44798)
                                    || (getTimer.timer > 273.0453 && getTimer.timer <= 274.496)) && (gesture.Name.Equals("Onigiri_Right")))
                                {
                                    Debug.Log("TIME SET 2.2:" + getTimer.timer + "Confidence :" + result.Confidence);
                                    scoreValue = result.Confidence * 100;
                                }

                                //////////////////////////////////////////////// Move_on SET
                                else if (((getTimer.timer > 16.44798 && getTimer.timer <= 17.94131) || (getTimer.timer > 19.86131 && getTimer.timer <= 21.75998))
                                    && (gesture.Name.Equals("Move_on_Left")))
                                {
                                    Debug.Log("TIME SET 3.1:" + getTimer.timer + "Confidence :" + result.Confidence);
                                    scoreValue = result.Confidence * 100;
                                }
                                else if (((getTimer.timer > 17.94131 && getTimer.timer <= 19.86131) || (getTimer.timer > 21.75998 && getTimer.timer <= 23.57331)) 
                                    && (gesture.Name.Equals("Move_on_Right")))
                                {
                                    Debug.Log("TIME SET 3.2:" + getTimer.timer + "Confidence :" + result.Confidence);
                                    scoreValue = result.Confidence * 100;
                                }

                                //////////////////////////////////////////////// SLOT01
                                else if ((getTimer.timer > 25.856 && getTimer.timer <= 26.26131) && (gesture.Name.Equals("Naja")))
                                {
                                    Debug.Log("TIME SET 4:" + getTimer.timer + "Confidence :" + result.Confidence);
                                    scoreValue = result.Confidence * 100;
                                }
                                else if ((getTimer.timer > 27.43465 && getTimer.timer <= 28.20265) || (getTimer.timer > 47.061 && getTimer.timer <= 47.744)
                                    && (gesture.Name.Equals("Bangloey")))
                                {
                                    Debug.Log("TIME SET 5:" + getTimer.timer + "Confidence :" + result.Confidence);
                                    scoreValue = result.Confidence * 100;
                                }
                                else if (((getTimer.timer > 29.65331 && getTimer.timer <= 30.20798) || (getTimer.timer > 129.7707 && getTimer.timer <= 130.368)) 
                                    && (gesture.Name.Equals("Nidnid")))
                                {
                                    Debug.Log("TIME SET 6:" + getTimer.timer + "Confidence :" + result.Confidence);
                                    scoreValue = result.Confidence * 100;
                                }
                                else if (((getTimer.timer > 31.27465 && getTimer.timer <= 31.91465) || (getTimer.timer > 41.451 && getTimer.timer <= 42.027)
                                    || (getTimer.timer > 131.84 && getTimer.timer <= 132.5013) || (getTimer.timer > 135.467 && getTimer.timer <= 136.384)) 
                                    && (gesture.Name.Equals("ChoeyMoey")))
                                {
                                    Debug.Log("TIME SET 7:" + getTimer.timer + "Confidence :" + result.Confidence);
                                    scoreValue = result.Confidence * 100;
                                }

                                //////////////////////////////////////////////// TakeUpArm
                                else if (((getTimer.timer > 32.61866 && getTimer.timer <= 33.92) || (getTimer.timer > 48.40533 && getTimer.timer <= 49.856)
                                    || (getTimer.timer > 137.8773 && getTimer.timer <= 138.432)) && (gesture.Name.Equals("TakeUpArm_Right")))
                                {
                                    Debug.Log("TIME SET 8.1:" + getTimer.timer + "Confidence :" + result.Confidence);
                                    scoreValue = result.Confidence * 100;
                                }
                                else if (((getTimer.timer > 34.666 && getTimer.timer <= 35.75465) || (getTimer.timer > 50.432 && getTimer.timer <= 51.41331)) 
                                    || (getTimer.timer > 139.1147 && getTimer.timer <= 140.012) && (gesture.Name.Equals("TakeUpArm_Left")))
                                {
                                    Debug.Log("TIME SET 8.2:" + getTimer.timer + "Confidence :" + result.Confidence);
                                    scoreValue = result.Confidence * 100;
                                }

                                //////////////////////////////////////////////// DrawBigHeart
                                else if (((getTimer.timer > 36.523 && getTimer.timer <= 38.016) || (getTimer.timer > 51.947 && getTimer.timer <= 53.76)
                                    || (getTimer.timer > 140.48 && getTimer.timer <= 142.0373))&& (gesture.Name.Equals("DrawBigHeart")))
                                {
                                    Debug.Log("TIME SET 9:" + getTimer.timer + "Confidence :" + result.Confidence);
                                    scoreValue = result.Confidence * 100;
                                }

                                //////////////////////////////////////////////// Yeah
                                else if (((getTimer.timer > 38.571 && getTimer.timer <= 39.829) || (getTimer.timer > 54.29331 && getTimer.timer <= 55.70132)
                                   || (getTimer.timer > 142.4213 && getTimer.timer <= 144.1707)) && (gesture.Name.Equals("Yeah")))
                                {
                                    Debug.Log("TIME SET 10:" + getTimer.timer + "Confidence :" + result.Confidence);
                                    scoreValue = result.Confidence * 100;
                                }

                                //////////////////////////////////////////////// TourPai
                                else if ((getTimer.timer > 43.371 && getTimer.timer <= 43.733) && (gesture.Name.Equals("TourPai")))
                                {
                                    Debug.Log("TIME SET 11:" + getTimer.timer + "Confidence :" + result.Confidence);
                                    scoreValue = result.Confidence * 100;
                                }

                                //////////////////////////////////////////////// Tummada
                                else if ((getTimer.timer > 45.291 && getTimer.timer <= 45.89) && (gesture.Name.Equals("Tummada")))
                                {
                                    Debug.Log("TIME SET 12:" + getTimer.timer + "Confidence :" + result.Confidence);
                                    scoreValue = result.Confidence * 100;
                                }

                                //////////////////////////////////////////////// Move_down
                                else if (((getTimer.timer > 56.68265 && getTimer.timer <= 56.87465) || (getTimer.timer > 58.091 && getTimer.timer <= 60.07465)
                                    || (getTimer.timer > 61.376 && getTimer.timer <= 61.67465) || (getTimer.timer > 64.555 && getTimer.timer <= 64.91733)
                                    || (getTimer.timer > 69.184 && getTimer.timer <= 69.78132) || (getTimer.timer > 144.7466 && getTimer.timer <= 145.3013)
                                    || (getTimer.timer > 146.9866 && getTimer.timer <= 148.416) || (getTimer.timer > 149.7387 && getTimer.timer <= 150.1866)
                                    || (getTimer.timer > 152.7253 && getTimer.timer <= 153.152) || (getTimer.timer > 157.76 && getTimer.timer <= 158.2933)) 
                                    && (gesture.Name.Equals("Move_down_Left")))
                                {
                                    Debug.Log("TIME SET 13.1:" + getTimer.timer + "Confidence :" + result.Confidence);
                                    scoreValue = result.Confidence * 100;
                                }
                                else if (((getTimer.timer > 57.344 && getTimer.timer <= 57.68533) || (getTimer.timer > 60.75732 && getTimer.timer <= 61.184)
                                    || (getTimer.timer > 62.08 && getTimer.timer <= 64.043) || (getTimer.timer > 65.23733 && getTimer.timer <= 65.51465)
                                    || (getTimer.timer > 68.224 && getTimer.timer <= 68.672) || (getTimer.timer > 145.8347 && getTimer.timer <= 146.4533)
                                    || (getTimer.timer > 148.7146 && getTimer.timer <= 149.2693) || (getTimer.timer > 150.6773 && getTimer.timer <= 152.2987)
                                    || (getTimer.timer > 153.8133 && getTimer.timer <= 154.2827) || (getTimer.timer > 156.8 && getTimer.timer <= 157.248)) 
                                    && (gesture.Name.Equals("Move_down_Right")))
                                {
                                    Debug.Log("TIME SET 13.2:" + getTimer.timer + "Confidence :" + result.Confidence);
                                    scoreValue = result.Confidence * 100;
                                }

                                //////////////////////////////////////////////// DownLeg
                                else if (((getTimer.timer > 65.77066 && getTimer.timer <= 67.776) || (getTimer.timer > 69.952 && getTimer.timer <= 71.403)
                                    || (getTimer.timer > 154.752 && getTimer.timer <= 156.352) || (getTimer.timer > 158.7413 && getTimer.timer <= 160.0426)) 
                                    && (gesture.Name.Equals("Down_leg")))
                                {
                                    Debug.Log("TIME SET 14:" + getTimer.timer + "Confidence :" + result.Confidence);
                                    scoreValue = result.Confidence * 100;
                                }

                                //////////////////////////////////////////////// LoveorNot
                                else if (((getTimer.timer > 72.91773 && getTimer.timer <= 73.49331) || (getTimer.timer > 74.667 && getTimer.timer <= 75.477)
                                    || (getTimer.timer > 161.1946 && getTimer.timer <= 161.856) || (getTimer.timer > 163.1147 && getTimer.timer <= 163.904))
                                    && (gesture.Name.Equals("LoveorNot")))
                                {
                                    Debug.Log("TIME SET 15:" + getTimer.timer + "Confidence :" + result.Confidence);
                                    scoreValue = result.Confidence * 100;
                                }

                                //////////////////////////////////////////////// Come_on
                                else if (((getTimer.timer > 75.92533 && getTimer.timer <= 77.93066) || (getTimer.timer > 164.5013 && getTimer.timer <= 166.4)
                                    || (getTimer.timer > 223.488 && getTimer.timer <= 225.4933)) && (gesture.Name.Equals("ComeOn")))
                                {
                                    Debug.Log("TIME SET 16:" + getTimer.timer + "Confidence :" + result.Confidence);
                                    scoreValue = result.Confidence * 100;
                                }

                                //////////////////////////////////////////////// LetsCookie
                                else if (((getTimer.timer > 78.61331 && getTimer.timer <= 79.7227) || (getTimer.timer > 167.168 && getTimer.timer <= 168.0853)
                                    || (getTimer.timer > 226.3893 && getTimer.timer <= 227.2213)) && (gesture.Name.Equals("LetsCookie")))
                                {
                                    Debug.Log("TIME SET 17:" + getTimer.timer + "Confidence :" + result.Confidence);
                                    scoreValue = result.Confidence * 100;
                                }

                                //////////////////////////////////////////////// Koisuru
                                else if (((getTimer.timer > 80.10664 && getTimer.timer <= 80.64) || (getTimer.timer > 167.168 && getTimer.timer <= 168.0853)
                                    || (getTimer.timer > 168.6613 && getTimer.timer <= 169.0027) || (getTimer.timer > 184.2346 && getTimer.timer <= 184.832)
                                    || (getTimer.timer > 227.584 && getTimer.timer <= 228.1387) || (getTimer.timer > 243.115 && getTimer.timer <= 243.5413)) 
                                    && (gesture.Name.Equals("Koisuru_Right")))
                                {
                                    Debug.Log("TIME SET 18:" + getTimer.timer + "Confidence :" + result.Confidence);
                                    scoreValue = result.Confidence * 100;
                                }
                                else if (((getTimer.timer > 80.87465 && getTimer.timer <= 81.451) || (getTimer.timer > 95.53065 && getTimer.timer <= 96.04266)
                                    || (getTimer.timer > 169.344 && getTimer.timer <= 169.728) || (getTimer.timer > 185.2373 && getTimer.timer <= 185.792)
                                    || (getTimer.timer > 228.288 && getTimer.timer <= 228.9492) || (getTimer.timer > 244.0533 && getTimer.timer <= 244.6507)) 
                                    && (gesture.Name.Equals("Koisuru_Left")))
                                {
                                    Debug.Log("TIME SET 18:" + getTimer.timer + "Confidence :" + result.Confidence);
                                    scoreValue = result.Confidence * 100;
                                }

                                //////////////////////////////////////////////// FortuneCookies
                                else if (((getTimer.timer > 81.92 && getTimer.timer <= 83.62664) || (getTimer.timer > 96.34132 && getTimer.timer <= 97.088)
                                    || (getTimer.timer > 170.1973 && getTimer.timer <= 171.84) || (getTimer.timer > 185.8347 && getTimer.timer <= 187.5627)
                                    || (getTimer.timer > 229.3546 && getTimer.timer <= 231.0613) || (getTimer.timer > 245.1413 && getTimer.timer <= 245.7413))
                                    && (gesture.Name.Equals("FurtuneCookies")))
                                {
                                    Debug.Log("TIME SET 19:" + getTimer.timer + "Confidence :" + result.Confidence);
                                    scoreValue = result.Confidence * 100;
                                }

                                //////////////////////////////////////////////// LetsWish
                                else if (((getTimer.timer > 83.968 && getTimer.timer <= 84.459) || (getTimer.timer > 172.2453 && getTimer.timer <= 172.928)
                                    || (getTimer.timer > 231.4026 && getTimer.timer <= 232) || (getTimer.timer > 247.3173 && getTimer.timer <= 247.744))
                                    && (gesture.Name.Equals("LetsWish_Right")))
                                {
                                    Debug.Log("TIME SET 20.1:" + getTimer.timer + "Confidence :" + result.Confidence);
                                    scoreValue = result.Confidence * 100;
                                }
                                else if (((getTimer.timer > 84.62932 && getTimer.timer <= 85.119) || (getTimer.timer > 173.248 && getTimer.timer <= 173.8027)
                                    || (getTimer.timer > 232.3627 && getTimer.timer <= 232.8746) || (getTimer.timer > 248.128 && getTimer.timer <= 248.4693))
                                    && (gesture.Name.Equals("LetsWish_Left")))
                                {
                                    Debug.Log("TIME SET 20.2:" + getTimer.timer + "Confidence :" + result.Confidence);
                                    scoreValue = result.Confidence * 100;
                                }

                                //////////////////////////////////////////////// HenWing
                                else if (((getTimer.timer > 85.52533 && getTimer.timer <= 87.38132) || (getTimer.timer > 100.0746 && getTimer.timer <= 103.2107)
                                    || (getTimer.timer > 174.2933 && getTimer.timer <= 176.864) || (getTimer.timer > 189.867 && getTimer.timer <= 191.808) 
                                    || (getTimer.timer > 233.28 && getTimer.timer <= 235.008) || (getTimer.timer > 249.0453 && getTimer.timer <= 250.752))
                                    && (gesture.Name.Equals("HenWing")))
                                {
                                    Debug.Log("TIME SET 21:" + getTimer.timer + "Confidence :" + result.Confidence);
                                    scoreValue = result.Confidence * 100;
                                }

                                //////////////////////////////////////////////// HeyHey
                                else if (((getTimer.timer > 88.08533 && getTimer.timer <= 93.056) || (getTimer.timer > 104.1065 && getTimer.timer <= 108.6933)
                                    || (getTimer.timer > 176.6613 && getTimer.timer <= 181.184) || (getTimer.timer > 192.512 && getTimer.timer <= 197.3973)
                                    || (getTimer.timer > 235.84 && getTimer.timer <= 240.6187) || (getTimer.timer > 251.4987 && getTimer.timer <= 256.32))
                                    && (gesture.Name.Equals("Heyhey")))
                                {
                                    Debug.Log("TIME SET 22:" + getTimer.timer + "Confidence :" + result.Confidence);
                                    scoreValue = result.Confidence * 100;
                                }

                                //////////////////////////////////////////////// Clap
                                else if (((getTimer.timer > 112.2987 && getTimer.timer <= 113.1307) || (getTimer.timer > 116.267 && getTimer.timer <= 116.928)
                                    || (getTimer.timer > 120.2987 && getTimer.timer <= 120.7893) || (getTimer.timer > 200.8746 && getTimer.timer <= 201.5573)
                                    || (getTimer.timer > 204.8213 && getTimer.timer <= 205.3546) || (getTimer.timer > 208.8746 && getTimer.timer <= 209.472)
                                    || (getTimer.timer > 259.8613 && getTimer.timer <= 260.5226) || (getTimer.timer > 263.8933 && getTimer.timer <= 264.4266)
                                    || (getTimer.timer > 267.776 && getTimer.timer <= 268.3733))
                                    && (gesture.Name.Equals("Clap")))
                                {
                                    Debug.Log("TIME SET 23:" + getTimer.timer + "Confidence :" + result.Confidence);
                                    scoreValue = result.Confidence * 100;
                                }

                                //////////////////////////////////////////////// Up_down
                                else if (((getTimer.timer > 121.5573 && getTimer.timer <= 128.0213) || (getTimer.timer > 210.0907 && getTimer.timer <= 215.1253))
                                    && (gesture.Name.Equals("Up_down")))
                                {
                                    Debug.Log("TIME SET 24:" + getTimer.timer + "Confidence :" + result.Confidence);
                                    scoreValue = result.Confidence * 100;
                                }

                                //////////////////////////////////////////////// Hairoo
                                else if ((getTimer.timer > 133.6747 && getTimer.timer <= 134.2507) && (gesture.Name.Equals("Hairoo")))
                                {
                                    Debug.Log("TIME SET 25:" + getTimer.timer + "Confidence :" + result.Confidence);
                                    scoreValue = result.Confidence * 100;
                                }

                                //////////////////////////////////////////////// Rotate
                                else if ((getTimer.timer > 268.6507 && getTimer.timer <= 270.528) && (gesture.Name.Equals("Rotate")))
                                {
                                    Debug.Log("TIME SET 26:" + getTimer.timer + "Confidence :" + result.Confidence);
                                    scoreValue = result.Confidence * 100;
                                }

                                //////////////////////////////////////////////// End
                                else if ((getTimer.timer > 276.8427 && getTimer.timer <= 280.448) && (gesture.Name.Equals("End")))
                                {
                                    Debug.Log("TIME SET 27:" + getTimer.timer + "Confidence :" + result.Confidence);
                                    scoreValue = result.Confidence * 100;
                                }

                                //////////////////////////////////////////////// Point
                                else if (((getTimer.timer > 216.6187 && getTimer.timer <= 217.4507) || (getTimer.timer > 218.88 && getTimer.timer <= 219.3493)) 
                                    && (gesture.Name.Equals("Point_Left")))
                                {
                                    Debug.Log("TIME SET 28:" + getTimer.timer + "Confidence :" + result.Confidence);
                                    scoreValue = result.Confidence * 100;
                                }
                                else if (((getTimer.timer > 215.616 && getTimer.timer <= 216.32) || (getTimer.timer > 218.048 && getTimer.timer <= 218.5173))
                                    && (gesture.Name.Equals("Point_Right")))
                                {
                                    Debug.Log("TIME SET 28:" + getTimer.timer + "Confidence :" + result.Confidence);
                                    scoreValue = result.Confidence * 100;
                                }

                                //////////////////////////////////////////////// Side
                                else if ((getTimer.timer > 220.3847 && getTimer.timer <= 223.3173) && (gesture.Name.Equals("Side")))
                                {
                                    Debug.Log("TIME SET 29:" + getTimer.timer + "Confidence :" + result.Confidence);
                                    scoreValue = result.Confidence * 100;
                                }

                                ///////// CONDITION ITEM

                                if(scoreValue >= 20)
                                {
                                    countCombo++;
                                    Debug.Log("COMBO ::::: " + countCombo);
                                    if (countCombo >= 2 && countCombo < 4)
                                    {
                                        itemx2 = true;
                                        scoreValue *= 2;
                                        //Debug.Log("COMBO COMBO COMBO COMBO COMBO AND scoreValue ="+ scoreValue);
                                    }
                                    else if(countCombo >=4)
                                    {
                                        //Debug.Log("BONUS TIME BONUS TIME BONUS TIME BONUS TIME BONUS TIME BONUS TIME");
                                        timeTemp = getTimer.timer + 10;
                                        itemTime = true;
                                    }
                                }

                                else if(scoreValue < 10)
                                {
                                    itemx2 = false;
                                    countCombo = 0;
                                    //Debug.Log("NO COMBO NO COMBO NO COMBO NO COMBO NO COMBO");
                                }

                                else if(getTimeout.timeout == false)
                                {
                                    //Debug.Log("BONUS TIME *** BONUS TIME *** BONUS TIME *** BONUS TIME *** BONUS TIME *** BONUS TIME ");
                                }
                                else if(getTimeout.timeout == true)
                                {
                                    //Debug.Log("OUT BONUS TIME *** OUT BONUS TIME *** OUT BONUS TIME *** OUT BONUS TIME *** OUT BONUS TIME *** OUT BONUS TIME ");
                                    timeTemp = 0;
                                }

                                Scoreup.score += scoreValue;
                                scoreValue = 0; 
                                Debug.Log("SCORE:" + Scoreup.score);

                                if(getTimer.timer > 5)
                                {
                                    Debug.Log("********** 5 SECONDS**********");
                                    loadScene = true;
                                }
                            }
                            else
                            {
                                //Debug.Log("result is NULL:"+result);
                            }
                        }
                    }
                }
            }
        }
    }
}