using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock : MonoBehaviour {
    [SerializeField] GameObject deposit;
    [SerializeField] GameObject cannister;
    [SerializeField] GameObject blowtorch;
    private bool empty;
    public AudioSource Audio;
    public AudioClip activated;
  
    void Start(){
        empty = true;
        blowtorch.GetComponent<Rigidbody>().isKinematic = true;
        blowtorch.GetComponent<BoxCollider>().enabled = false;
        
    }

    void Update(){
        
    }

    private void OnTriggerEnter(Collider collider){
        if (collider.tag == "Fuel Cannister" && empty == true){
            Refuel();

        }

    }

    private void Refuel(){
        blowtorch.GetComponent<Rigidbody>().isKinematic = false;
        blowtorch.GetComponent<BoxCollider>().enabled = true;
        Debug.Log("Activated!");
        Audio.clip = activated;
        Audio.Play();

    }
}