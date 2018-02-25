using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestTrigger : MonoBehaviour
{

    private GameObject collidingObject;
    public IEnumerator OnTriggerEnter()
    {

           collidingObject = GameObject.Find("key_silver");
           collidingObject.layer = 12;
           yield return new WaitForSeconds(2);
           GameObject water = GameObject.Find("water");
           water.GetComponent<WaterTime>().ShrinkEvent();
           GameObject.FindWithTag("gold_key").delete();
           Explode();
        Debug.Log("Silver key is in");
    }
    void Explode()
    {
        var exp = GetComponent<ParticleSystem>();
        exp.Play();
        Destroy(exp);
    }

    // Update is called once per frame
    void Update()
    {

    }


}
