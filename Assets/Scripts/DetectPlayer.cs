using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectPlayer : MonoBehaviour
{  
    public GameObject player;

    
    // Start is called before the first frame update
    void Start()
    {
        
        Collider cd = this.gameObject.GetComponent <BoxCollider> ();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) {
            
            Debug.Log("Collison detected");
        
        }
    }
}
