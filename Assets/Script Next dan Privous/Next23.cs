using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Next23 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Display;
    public GameObject D2, D3;
    public int frame;

    //public bool isClicked = false;
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
       
    }
    private void FixedUpdate()
    {
        if (frame <= 10000)
        {
            Debug.Log("Frame: " + frame);
            frame++;
        }
        nextScreen2();
    }
    //private 
    public void nextScreen2() {
        D3.SetActive(true);
        D2.SetActive(false);
        Debug.Log("display3 nyala");
    }
    public IEnumerator Wait(float seconds)
    {
        Debug.Log("Started Coroutine at timestamp : " + Time.time);
        yield return new WaitForSeconds(seconds);
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }
    //private void OnTriggerEnter(Collider other)
    //{
    //    //if (other.tag == "player")
    //    //{
    //    //   Display.Find("DISPLAY2").SetActive(true);
    //    //  Display.Find("DISPLAY1").SetActive(false);
    //    //  D2= Display.transform.Find("DISPLAY2").GetComponent <GameObject>();
    //    // D1 =Display.transform.Find("DISPLAY1").GetComponent<GameObject>();
    //    if (CL.isClicked == false)
    //    {

    //        CL.isClicked = true;
    //    }

    //    // }
    //    //else
    //    //{
    //    //  Debug.Log("tag="+other.tag);

    //    // }
    //}

    //private void OnTriggerExit(Collider other)
    //{
    //    CL.isClicked = false;
    //}
}
