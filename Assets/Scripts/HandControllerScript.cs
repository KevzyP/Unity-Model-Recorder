using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HandControllerScript : MonoBehaviour
{
    [SerializeField] InputActionReference controllerActionGrip;
    [SerializeField] InputActionReference controllerActionTrigger;
    [SerializeField] InputActionReference controllerActionPrimaryButton;
    [SerializeField] InputActionReference controllerActionSecondaryButton;

    private Animator _handAnimator;

    // Start is called before the first frame update
    void Awake()
    {
        controllerActionGrip.action.performed += GripPress;
        controllerActionTrigger.action.performed += TriggerPress;
        controllerActionPrimaryButton.action.performed += PrimaryButtonPress;
        controllerActionSecondaryButton.action.performed += SecondaryButtonPress;
        controllerActionSecondaryButton.action.canceled += SecondaryButtonRelease;

        _handAnimator = GameObject.Find("erika_archer@T-Pose").GetComponent<Animator>();
    }

    private void SecondaryButtonRelease(InputAction.CallbackContext obj) => _handAnimator.SetFloat("L_Handshake", obj.ReadValue<float>());

    private void SecondaryButtonPress(InputAction.CallbackContext obj) => _handAnimator.SetFloat("L_Handshake", obj.ReadValue<float>());

    private void PrimaryButtonPress(InputAction.CallbackContext obj) => _handAnimator.SetFloat("PrimaryButton", obj.ReadValue<float>());


    private void TriggerPress(InputAction.CallbackContext obj) => _handAnimator.SetFloat("Pose", obj.ReadValue<float>());


    private void GripPress(InputAction.CallbackContext obj) => _handAnimator.SetFloat("Grip", obj.ReadValue<float>());
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
