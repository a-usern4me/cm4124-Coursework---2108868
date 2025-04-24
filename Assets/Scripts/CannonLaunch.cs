using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonLaunch : MonoBehaviour {
    [SerializeField] GameObject brotherRay;
    public GameObject shell;
    private bool fixedNow = false;
    private bool firing = false;
    public AudioSource Audio;
    public AudioClip shelling;
    
    void Start(){
      
    }

    void Update(){
        GameObject sp;
        Rigidbody body;
       
        if (fixedNow == true && firing == false){
            firing = true;
            sp = Instantiate(shell, brotherRay.transform.position + (transform.forward * 3f) + (transform.up * 0f), Quaternion.identity);
			body = sp.AddComponent (typeof (Rigidbody)) as Rigidbody;
			body.AddRelativeForce(brotherRay.transform.forward.normalized * 3000);
            Audio.clip = shelling;
            Audio.Play();
           
        } else {
            //Debug.Log("Broken!");
        }

    }
        
    private void OnCollisionEnter(Collision collider){
        if (collider.gameObject.tag == "Blowtorch" && fixedNow == false){
            //Debug.Log("Fire");
            fixedNow = true;
            
        }
    }
}