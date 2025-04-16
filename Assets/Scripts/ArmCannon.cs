using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ArmCannon : MonoBehaviour {
    public GameObject what;
    public GameObject cannon;
    public InputActionReference triggerInputActionReference;
    private float triggerValue;
    private GameObject sp;
    private Rigidbody body;
    public bool works = false;

    void Start(){
      
    }

    void Update(){
        spawn();
   
    }

    public void spawn(){
        //if (sp != null) Destroy(sp);
        if (triggerValue != triggerInputActionReference.action.ReadValue<float>()){
            sp = Instantiate(what, cannon.transform.position + (transform.forward * 1) + (transform.up * 0), Quaternion.identity);
			    body = sp.AddComponent (typeof (Rigidbody)) as Rigidbody;
			    body.AddForce(transform.forward.normalized * 10000);
        }
    }
}