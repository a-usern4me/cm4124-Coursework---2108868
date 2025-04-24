using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OceanSounds : MonoBehaviour {
    public GameObject Ocean;
  
    void Start(){

    }

    void Update(){
        
    }

    private void OnCollisionEnter(Collision collider){
        if (collider.gameObject.tag == "Container"){
            Destroy(collider.gameObject);
        }
    }
}