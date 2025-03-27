using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkersLift : MonoBehaviour {
    public Rigidbody platform;
    
    void Start(){
        
    }

    
    void Update(){
        platform.transform.position += Vector3.up * 0.2f * Time.deltaTime;
  
    }
}
