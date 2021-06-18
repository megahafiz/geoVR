using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Next4142 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Display;
    public GameObject D41, D42;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

     public void nextScreen41()
    {
        D42.SetActive(true);
        D41.SetActive(false);
        Debug.Log("display41 nyala");
    }
    /*private void OnTriggerEnter(Collider other)
    {
        //if (other.tag == "player")
        //{
        //   Display.Find("DISPLAY2").SetActive(true);
        //  Display.Find("DISPLAY1").SetActive(false);
        //  D2= Display.transform.Find("DISPLAY2").GetComponent <GameObject>();
        // D1 =Display.transform.Find("DISPLAY1").GetComponent<GameObject>();
        D42.SetActive(true);
        D41.SetActive(false);
        Debug.Log("display3 nyala");

        // }
        //else
        //{
        //  Debug.Log("tag="+other.tag);

        // }
    }*/
}
