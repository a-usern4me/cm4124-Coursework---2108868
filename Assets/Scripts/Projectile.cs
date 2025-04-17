using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {
    public Rigidbody cannon;
    
    void Start(){
        
    }

    void Update(){
    
        
    }

    void OnCollisionEnter(Collision Collider){
        if (Collider.gameObject.tag == "Ground"){
            Destroy(this.gameObject);
        }

        if (Collider.gameObject.tag == "Player"){
            Destroy(this.gameObject);
        }

        if (Collider.gameObject.tag == "Crates"){
            Destroy(this.gameObject);
            Destroy(Collider.gameObject);
        }
    }
}