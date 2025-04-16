using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoGrab : MonoBehaviour {
    public Rigidbody fuel;

    void Start(){

    }

    void Update(){

    }

    /*void OnCollisionEnter(Collision Collider){
       if (Collider.gameObject.tag == "Crates"){
        fuel.GetComponent<Rigidbody>().isKinematic = true;
        fuel.GetComponent<BoxCollider>().enabled = false;

       } else {
        fuel.GetComponent<Rigidbody>().isKinematic = false;
        fuel.GetComponent<BoxCollider>().enabled = true;
       }
        
    }*/

}

