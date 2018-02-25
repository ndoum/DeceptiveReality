using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GardeningScript : MonoBehaviour {

    public GameObject silverKey;

    public GameObject silverKeySpawnpoint;

    public WaterTime water;

    public void OnTriggerEnter(Collider other)
    {

        ControllerGrabObject controller = other.GetComponent<ControllerGrabObject>();

        if (controller != null && water.WaterIsRising) {
            silverKey.SetActive(true);
            Debug.Log(silverKeySpawnpoint.transform.position);
            //moves the silverKey to the spawnpoint position
            silverKey.transform.position = silverKeySpawnpoint.transform.position;
        }
        /*
        if (controller != null && water.WaterIsRising && controller.triggerPressed)
        {
            silverKey.SetActive(true);
            Debug.Log(silverKeySpawnpoint.transform.position);
            //moves the silverKey to the spawnpoint position
            silverKey.transform.position = silverKeySpawnpoint.transform.position;
        }*/

    }


// Update is called once per frame
void Update () {
		
	}
}
