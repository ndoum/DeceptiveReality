using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiscInteraction : MonoBehaviour {

    public WaterTime water;

    bool hadPunishmentOnce = false;
    public void OnTriggerEnter(Collider other)
    {
        ControllerGrabObject controller = other.GetComponent<ControllerGrabObject>();

        if (controller != null && water.WaterIsRising && hadPunishmentOnce == false)
        {
            hadPunishmentOnce = true;
            water.IncreaseWater();
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
