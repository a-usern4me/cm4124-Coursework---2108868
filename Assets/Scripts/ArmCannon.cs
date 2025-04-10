using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ArmCannon : MonoBehaviour {
    //public GameObject leftController;
    //public GameObject leftController;
    public GameObject what;
    public InputActionReference triggerInputActionReference;

    private float triggerValue;
   

    void Start(){
        //controller = GetComponent<ActionBasedController>();
        
        
    }

    void Update(){
        //bool triggerValue;

        //triggerValue = triggerInputActionReference.action.ReadValue<float>();
        spawn();

       

    }

    public void spawn(){
         if (triggerValue != triggerInputActionReference.action.ReadValue<float>()){
             Instantiate(what);
            
        }
    }


}