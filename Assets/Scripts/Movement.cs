//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.XR.Interaction.Toolkit;
//using UnityEngine.InputSystem;
//using UnityEditor.Recorder;

//public class ActivateRecording : MonoBehaviour
//{
//    // Start is called before the first frame update
//    [SerializeField] InputActionAsset actionAsset;
//    [SerializeField] string controllerName;
//    [SerializeField] string PrimaryButton;
//    [SerializeField] string SecondaryButton;
//    [SerializeField] string TriggerButton;

//    private InputActionMap m_actionMap;
//    private InputAction m_inputActionPrimaryButton;
//    private InputAction m_inputActionSecondaryButton;
//    private InputAction m_inputActionTrigger;


//    // bool activated;
//    void Awake()
//    {
//        //get actions
//        m_actionMap = actionAsset.FindActionMap(controllerName);
//        m_inputActionPrimaryButton = m_actionMap.FindAction(PrimaryButton);
//        m_inputActionSecondaryButton = m_actionMap.FindAction(SecondaryButton);
//        m_inputActionTrigger = m_actionMap.FindAction(TriggerButton);


//    }

//    private void OnEnable()
//    {
//        m_inputActionPrimaryButton.Enable();
//        m_inputActionSecondaryButton.Enable();
//        m_inputActionTrigger.Enable();
//        //  GameObject.Find("Recorder").GetComponent<Recorder_Controller>().Prepare();
//        //activated = true;
//    }

//    private void OnDisable()
//    {
//        m_inputActionPrimaryButton.Disable();
//        m_inputActionSecondaryButton.Disable();
//        m_inputActionTrigger.Disable();
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        var PrimaryButtonPress = m_inputActionPrimaryButton.ReadValue<float>();
//        var SecondaryButtonPress = m_inputActionSecondaryButton.ReadValue<float>();
//        var triggerValue = m_inputActionTrigger.ReadValue<float>();

//        if (triggerValue == 1)
//        {
//            GameObject.Find("Recorder").GetComponent<Recorder_Controller>().Record();
//            //PrimaryButtonPress = 0;
//            //activated = true;
//        }
//        else if (SecondaryButtonPress == 1)
//        {
//            GameObject.Find("Recorder").GetComponent<Recorder_Controller>().stopRecord();

//            SecondaryButtonPress = 0;
//            //GameObject.Find("Recorder").GetComponent<Recorder_Controller>().Prepare();
//            //activated = false;
//        }

//    }


//}
