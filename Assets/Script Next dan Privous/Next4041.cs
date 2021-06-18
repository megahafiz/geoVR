using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Next4041 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Display;
    public GameObject D40, D41;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    
    public void nextScreen40()
    {
        D41.SetActive(true);
        D40.SetActive(false);
        Debug.Log("display40 nyala");
    }
    /*private void OnTriggerEnter(Collider other)
    {
        //if (other.tag == "player")
        //{
        //   Display.Find("DISPLAY2").SetActive(true);
        //  Display.Find("DISPLAY1").SetActive(false);
        //  D2= Display.transform.Find("DISPLAY2").GetComponent <GameObject>();
        // D1 =Display.transform.Find("DISPLAY1").GetComponent<GameObject>();
        D41.SetActive(true);
        D40.SetActive(false);
        Debug.Log("display3 nyala");

        // }
        //else
        //{
        //  Debug.Log("tag="+other.tag);

        // }
    }*/
}
