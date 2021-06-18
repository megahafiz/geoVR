using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Next1516 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Display;
    public GameObject D15, D16;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void nextScreen15()
    {
        D16.SetActive(true);
        D15.SetActive(false);
        Debug.Log("display3 nyala");
    }
        //private void OnTriggerEnter(Collider other)
        // {
        //if (other.tag == "player")
        //{
        //   Display.Find("DISPLAY2").SetActive(true);
        //  Display.Find("DISPLAY1").SetActive(false);
        //  D2= Display.transform.Find("DISPLAY2").GetComponent <GameObject>();
        // D1 =Display.transform.Find("DISPLAY1").GetComponent<GameObject>();


        // }
        //else
        //{
        //  Debug.Log("tag="+other.tag);

        // }
        //}
    }
