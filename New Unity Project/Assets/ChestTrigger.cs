using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestTrigger : MonoBehaviour
{

    private GameObject collidingObject;
    public IEnumerator OnTriggerEnter()
    {
        //GoldScript goldScript = GetComponent<GoldScript>();
        //GameObject.FindWithTag("key_gold").GetComponent<GoldScript>().delete();


        collidingObject = GameObject.Find("key_silver");
        collidingObject.layer = 12;
        yield return new WaitForSeconds(2);
        GameObject water = GameObject.Find("water");
        water.GetComponent<WaterTime>().ShrinkEvent();


        //Destroy(GameObject.Find("pPlane3"));
        /*Issue was saying gold_key instead of key_gold*/

        //GameObject.FindWithTag("key_gold").goldScript.delete();
        //Edward's line of code
        //GameObject.FindWithTag("gold_key").delete()
        //henry
        //GameObject.FindWithTag("gold_key").Destroy();
        Explode();
        Debug.Log("Silver key is in");
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
