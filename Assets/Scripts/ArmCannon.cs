using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ArmCannon : MonoBehaviour {
    public GameObject ammo;
    public GameObject cannon;
    public InputActionReference triggerInputActionReference;
    private float triggerValue;
    private GameObject sp;
    private Rigidbody body;
    public AudioSource Audio;
    public AudioClip fire; 

    void Start(){
      
    }

    void Update(){
        spawn();
    }

    public void spawn(){
        if (triggerValue != triggerInputActionReference.action.ReadValue<float>()){
            Audio.clip = fire;
            Audio.Play();
            sp = Instantiate(ammo, cannon.transform.position + (transform.forward * 0.4f) + (transform.up * 0.1f), Quaternion.identity);
			body = sp.AddComponent (typeof (Rigidbody)) as Rigidbody;
			body.AddRelativeForce(cannon.transform.forward.normalized * 15000);
        }
    }
}