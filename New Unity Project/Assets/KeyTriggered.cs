using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyTriggered : MonoBehaviour {

    private GameObject collidingObject;

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Key is in");
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
