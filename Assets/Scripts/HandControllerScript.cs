using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HandControllerScript : MonoBehaviour
{
    [SerializeField] InputActionReference L_controllerActionGrip;
    [SerializeField] InputActionReference L_controllerActionTrigger;
    [SerializeField] InputActionReference L_controllerActionPrimaryButton;
    [SerializeField] InputActionReference L_controllerActionSecondaryButton;

    [SerializeField] InputActionReference R_controllerActionGrip;
    [SerializeField] InputActionReference R_controllerActionTrigger;
    [SerializeField] InputActionReference R_controllerActionPrimaryButton;
    [SerializeField] InputActionReference R_controllerActionSecondaryButton;

    private Animator _handAnimator;

    // Start is called before the first frame update
    void Awake()
    {
        L_controllerActionGrip.action.performed += L_GripPress;
        L_controllerActionTrigger.action.performed += L_TriggerPress;
        L_controllerActionPrimaryButton.action.performed += L_PrimaryButtonPress;
        L_controllerActionPrimaryButton.action.canceled += L_PrimaryButtonRelease;
        L_controllerActionSecondaryButton.action.performed += L_SecondaryButtonPress;
        L_controllerActionSecondaryButton.action.canceled += L_SecondaryButtonRelease;

        R_controllerActionGrip.action.performed += R_GripPress;
        R_controllerActionTrigger.action.performed += R_TriggerPress;
        R_controllerActionPrimaryButton.action.performed += R_PrimaryButtonPress;
        R_controllerActionPrimaryButton.action.canceled += R_PrimaryButtonRelease;
        R_controllerActionSecondaryButton.action.performed += R_SecondaryButtonPress;
        R_controllerActionSecondaryButton.action.canceled += R_SecondaryButtonRelease;

        _handAnimator = GameObject.Find("OriginalModel").GetComponent<Animator>();
    }

    private void R_PrimaryButtonPress(InputAction.CallbackContext obj) => _handAnimator.SetFloat("R_Handshake", obj.ReadValue<float>());
    private void R_PrimaryButtonRelease(InputAction.CallbackContext obj) => _handAnimator.SetFloat("R_Handshake", obj.ReadValue<float>());
    private void R_SecondaryButtonPress(InputAction.CallbackContext obj) => _handAnimator.SetFloat("R_Wave", obj.ReadValue<float>());
    private void R_SecondaryButtonRelease(InputAction.CallbackContext obj) => _handAnimator.SetFloat("R_Wave", obj.ReadValue<float>());
    private void R_TriggerPress(InputAction.CallbackContext obj) => _handAnimator.SetFloat("R_FacePalm", obj.ReadValue<float>());
    private void R_GripPress(InputAction.CallbackContext obj) => _handAnimator.SetFloat("R_GiveItem", obj.ReadValue<float>());

    private void L_PrimaryButtonPress(InputAction.CallbackContext obj) => _handAnimator.SetFloat("L_Handshake", obj.ReadValue<float>());
    private void L_PrimaryButtonRelease(InputAction.CallbackContext obj) => _handAnimator.SetFloat("L_Handshake", obj.ReadValue<float>());
    private void L_SecondaryButtonPress(InputAction.CallbackContext obj) => _handAnimator.SetFloat("L_Wave", obj.ReadValue<float>());
    private void L_SecondaryButtonRelease(InputAction.CallbackContext obj) => _handAnimator.SetFloat("L_Wave", obj.ReadValue<float>());
    private void L_TriggerPress(InputAction.CallbackContext obj) => _handAnimator.SetFloat("L_FacePalm", obj.ReadValue<float>());
    private void L_GripPress(InputAction.CallbackContext obj) => _handAnimator.SetFloat("L_GiveItem", obj.ReadValue<float>());




    // Update is called once per frame
    void Update()
    {

    }
}
