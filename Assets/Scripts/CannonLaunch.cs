using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonLaunch : MonoBehaviour {
    [SerializeField] GameObject brotherRay;
    public GameObject what;
    private bool fixedNow = false;
    private bool firing = false;
     public AudioSource Audio;
    public AudioClip activated;

    void Start(){
      
    }

    void Update(){
        GameObject sp;
        Rigidbody body;
       
        if (fixedNow == true && firing == false){
            firing = true;
            sp = Instantiate(what, brotherRay.transform.position + (transform.forward * 3f) + (transform.up * 0f), Quaternion.identity);
			body = sp.AddComponent (typeof (Rigidbody)) as Rigidbody;
			body.AddRelativeForce(brotherRay.transform.forward.normalized * 3000);
            //body.velocity = transform.TransformDirection(Vector3.forward * 10000);
            //body.AddForce(Vector3.forward.normalized * 3000);
            //body.velocity = transform.TransformDirection(Vector3.forward * 3000);
            
        } else {
            Debug.Log("Broken!");
        }

    }
        
    private void OnCollisionEnter(Collision collider){
        if (collider.gameObject.tag == "Blowtorch" && fixedNow == false){
            //MendLever();
            Debug.Log("Fire");
            fixedNow = true;
            Audio.clip = activated;
            Audio.Play();

        }

    }
}