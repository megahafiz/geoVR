using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Next3839 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Display;
    public GameObject D38, D39;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

     public void nextScreen38()
    {
        D39.SetActive(true);
        D38.SetActive(false);
        Debug.Log("display38 nyala");
    }
    /*private void OnTriggerEnter(Collider other)
    {
        //if (other.tag == "player")
        //{
        //   Display.Find("DISPLAY2").SetActive(true);
        //  Display.Find("DISPLAY1").SetActive(false);
        //  D2= Display.transform.Find("DISPLAY2").GetComponent <GameObject>();
        // D1 =Display.transform.Find("DISPLAY1").GetComponent<GameObject>();
        D39.SetActive(true);
        D38.SetActive(false);
        Debug.Log("display3 nyala");

        // }
        //else
        //{
        //  Debug.Log("tag="+other.tag);

        // }
    }*/
}
