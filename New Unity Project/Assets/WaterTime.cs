using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterTime : MonoBehaviour {
    public bool WaterIsRising = false;
    private bool WaterIsShrinking = false;
    private bool happened = false;
    private void Start()
    {
        transform.position = new Vector3(0, -1.2f, 0);
    }
    public void KeyEvent()
    {
        WaterIsRising = true;
        if (!happened)
        {
            transform.position = new Vector3(0, -.8f, 0);
            happened = true;
        }
    }

    public void ShrinkEvent()
    {
        WaterIsRising = false;
        WaterIsShrinking = true;
    }

    IEnumerator Wait()
    {
        Debug.Log("Waiting");
        yield return new WaitForSeconds(5);
    }
	// Update is called once per frame
	void Update () {
		if (WaterIsRising)
        {
            Vector3 current = transform.position;
            transform.position = new Vector3(0, current.y+=0.005f*Time.deltaTime, 0);
        }
        else if (WaterIsShrinking)
        {
            Vector3 current = transform.position;
            transform.position = new Vector3(0, current.y -= 0.02f * Time.deltaTime, 0);
        }
    }
}
