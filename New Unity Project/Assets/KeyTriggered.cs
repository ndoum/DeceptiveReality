using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyTriggered : MonoBehaviour {

    private GameObject collidingObject;

    public IEnumerator OnTriggerEnter()
    {
        collidingObject = GameObject.Find("key_gold");
        GameObject.FindWithTag("key_gold").layer = 10;
        yield return new WaitForSeconds(2);
        GameObject.FindWithTag("key_gold").SetActive(false);
        Explode();
        Debug.Log("Key is in");
    }
    void Explode()
    {
        var exp = GetComponent<ParticleSystem>();
        exp.Play();
        Destroy(gameObject);
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }


}
