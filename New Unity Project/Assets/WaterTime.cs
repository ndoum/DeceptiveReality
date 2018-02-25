using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaterTime : MonoBehaviour {
    public bool WaterIsRising = false;
    private bool WaterIsShrinking = false;
    public Text lose;

    private void Start()
    {
        transform.position = new Vector3(0, -1.3f, 0);
    }
    public void KeyEvent()
    {
        WaterIsRising = true;

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
            transform.position = new Vector3(0, current.y+=0.01f*Time.deltaTime, 0);
        }
        else if (WaterIsShrinking)
        {
            Vector3 current = transform.position;
            transform.position = new Vector3(0, current.y -= 0.02f * Time.deltaTime, 0);
        }
        if ( transform.position.y >= 0.36f)
        {
            lose.enabled = true;

        }
    }

    public void IncreaseWater()
    {
        Vector3 current = transform.position;
        transform.position = new Vector3(0, current.y += .30f, 0);
    }
}
