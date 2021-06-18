using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Next4748: MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Display;
    public GameObject D47, D48;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
     public void nextScreen47()
    {
        D48.SetActive(true);
        D47.SetActive(false);
        Debug.Log("display47 nyala");
    }
    /*private void OnTriggerEnter(Collider other)
    {
        //if (other.tag == "player")
        //{
        //   Display.Find("DISPLAY2").SetActive(true);
        //  Display.Find("DISPLAY1").SetActive(false);
        //  D2= Display.transform.Find("DISPLAY2").GetComponent <GameObject>();
        // D1 =Display.transform.Find("DISPLAY1").GetComponent<GameObject>();
        D48.SetActive(true);
        D47.SetActive(false);
        Debug.Log("display3 nyala");

        // }
        //else
        //{
        //  Debug.Log("tag="+other.tag);

        // }
    }*/
}
