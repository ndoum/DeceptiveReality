using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyTriggered : MonoBehaviour
{

    private GameObject collidingObject;

    public GameObject water;

    public GameObject silverKey;

    public GameObject silverKeySpawnpoint;

    public bool transitionSong = false;

    public void OnTriggerEnter(Collider other)
    {
        DeleteGold key = other.GetComponent<DeleteGold>();

        if (key != null)
        {
            water.GetComponent<WaterTime>().KeyEvent();
            Destroy(other.gameObject);
            Explode();
            silverKey.transform.position = silverKeySpawnpoint.transform.position;

            Debug.Log("Key is in");

        }

        // yield return new WaitForSeconds(2);

        //GameObject.FindWithTag("key_gold").SetActive(false);
        //Throws KeyGold right outta the map
        //GameObject.FindWithTag("key_gold").transform.position = new Vector3(25.4f, 26.3f, 11);

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
