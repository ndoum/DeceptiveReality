using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyTriggered : MonoBehaviour {

    private GameObject collidingObject;
    public IEnumerator OnTriggerEnter( Collider col)
    {

         collidingObject = GameObject.FindWithTag("key_gold");
          GameObject.FindWithTag("key_gold").layer = 10;
         yield return new WaitForSeconds(2);
         GameObject water = GameObject.FindWithTag("water");
         water.GetComponent<WaterTime>().KeyEvent();
         GameObject.FindWithTag("key_gold").SetActive(false);
         Explode();
        GameObject.FindWithTag("key_silver").transform.position = new Vector3(25.4f, 26.3f, 11);

        Debug.Log("Key is in"); 
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
