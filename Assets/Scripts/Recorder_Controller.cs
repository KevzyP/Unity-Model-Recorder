using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Recorder;
using System.IO;
using System;

public class Recorder_Controller : MonoBehaviour
{
    
    RecorderController m_RecorderController;
    public GameObject ObjectToRecord;

    //public Animator dummy_playback;
    //public float timer = 0;
    // Start is called before the first frame update
    void OnEnable()
    {
        Setup();
        
    }


    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.R)) 
        //{
        //    Record();

        //}
        //if(Input.GetKeyUp(KeyCode.R))
        //{
        //    stopRecord();
        //}
    }
    
    void Setup()
    {
        //setup controller
        var controllerSettings = ScriptableObject.CreateInstance<RecorderControllerSettings>();
        m_RecorderController = new RecorderController(controllerSettings);

        //setup animation clip
        var animationRecorder = ScriptableObject.CreateInstance<AnimationRecorderSettings>();
        animationRecorder.Enabled = true;
        animationRecorder.name = "My Anim Recorder";
        animationRecorder.AnimationInputSettings.gameObject = ObjectToRecord;
        animationRecorder.AnimationInputSettings.Recursive = true;
        animationRecorder.AnimationInputSettings.AddComponentToRecord(typeof(Transform));

        //setup output
        animationRecorder.OutputFile = "D:\\Yes\\Unity Recorder Experiment\\Assets\\Animations\\animResult";
        controllerSettings.AddRecorderSettings(animationRecorder);
        RecorderOptions.VerboseMode = true;
    }
    
       
    public void Record()
    {
        //dummy_playback.enabled = false;
        m_RecorderController.PrepareRecording();
        m_RecorderController.StartRecording();
    }

    public void stopRecord()
    {
        m_RecorderController.StopRecording();
        //StartCoroutine(CR_TestPlayback());
    }

    //private IEnumerator CR_TestPlayback()
    //{
    //    Debug.Log("Wait Start");
    //    yield return new WaitForSeconds(5f);
    //    Debug.Log("Wait Ready");
    //    Debug.Log("Playback");
        

    //}
}
