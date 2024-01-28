using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HandInput : MonoBehaviour
{

    public InputActionProperty pinch;
    public Animator animator;
    public InputActionProperty grip;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float triggerValue = pinch.action.ReadValue<float>();
        animator.SetFloat("Trigger", triggerValue);

        float gripValue = grip.action.ReadValue<float>();
        animator.SetFloat("Grip", gripValue);

        
    }
}
