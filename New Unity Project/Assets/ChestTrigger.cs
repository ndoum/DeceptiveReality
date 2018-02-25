using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChestTrigger : MonoBehaviour
{
    public Text win;

    public GameObject water;

    private GameObject collidingObject;

    public void OnTriggerEnter(Collider other)
    {
        SilverKeyScript key = other.GetComponent<SilverKeyScript>();

        if (key != null) {
            water.GetComponent<WaterTime>().ShrinkEvent();
            Destroy(other.gameObject);

            Explode();
            Debug.Log("Silver Key is in");
            win.enabled = true;
            win.text = "You Win!";
            win.color = Color.yellow;


        }

    }
    void Explode()
    {
        var exp = GetComponent<ParticleSystem>();
        exp.Play();
        //delete(exp);
        Destroy(exp);
    }

    // Update is called once per frame
    void Update()
    {

    }


}
