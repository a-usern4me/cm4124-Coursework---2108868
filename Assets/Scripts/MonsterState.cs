using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterState : MonoBehaviour {
    public GameObject monster;
    public Animator anim;
    public bool hit = false;
   
    void Start(){
      
    }

    void Update(){
        if (hit == true){
            //Debug.Log("Working");
            anim.SetBool("Defeated", true);
        } 
    }

    private void OnCollisionEnter(Collision collider){
        if (collider.gameObject.tag == "CannonRound"){
            hit = true;
            //Debug.Log("Hit!");
            Destroy(collider.gameObject);
        }
    }
}