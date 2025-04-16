using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ArmCannon : MonoBehaviour {
    //public GameObject leftController;
    //public GameObject leftController;
    public GameObject what;
    public GameObject player;
    public InputActionReference triggerInputActionReference;

    private bool firing = false;

    private float triggerValue;
   

    void Start(){
        //controller = GetComponent<ActionBasedController>();
        
        
    }

    void Update(){
        //bool triggerValue;

        //triggerValue = triggerInputActionReference.action.ReadValue<float>();
        if (triggerValue != triggerInputActionReference.action.ReadValue<float>()){
            firing = true;
        } else {
            firing = false;
        }

        if (firing == true){
            spawn();
        }
     
    }

    GameObject sp;
    Rigidbody body;

    public void spawn(){
         //if (triggerValue != triggerInputActionReference.action.ReadValue<float>()){
             //Instantiate(what);


            
            sp = Instantiate(what, player.transform.position + (transform.forward * 1) + (transform.up * 1), Quaternion.identity);
			body = sp.AddComponent (typeof (Rigidbody)) as Rigidbody;
			body.AddRelativeForce (player.transform.forward.normalized * 2000);
            firing = false;
            
        //}
    }


}