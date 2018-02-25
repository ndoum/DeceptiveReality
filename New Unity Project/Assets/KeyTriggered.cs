using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyTriggered : MonoBehaviour
{

    private GameObject collidingObject;

    public GameObject water;

    public ControllerGrabObject controller1;

    public ControllerGrabObject controller2;

    public bool transitionSong = false;

    public void OnTriggerEnter(Collider other)
    {
        GoldKeyScript key = other.GetComponent<GoldKeyScript>();

        if (key != null)
        {
            water.GetComponent<WaterTime>().KeyEvent();

            controller1.ReleaseObject();
            controller2.ReleaseObject();
            Destroy(other.gameObject);
            
            Debug.Log("Gold Key is in");

        }


    }
    void Explode()
    {
        ParticleSystem exp = GetComponent<ParticleSystem>();

        //Stops initial song, starts next song
        transitionSong = true;

        exp.Play();
        Destroy(exp);
    }



    // Update is called once per frame
    void Update()
    {

    }


}
