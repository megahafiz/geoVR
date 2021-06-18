using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class next: MonoBehaviour
{
    // Start is called before the first frame update//
    public GameObject Display;
    public GameObject D1, D2;
    //public bool isClicked = CL.isClicked;
    void Start()
    {
        
    }

    public void nextScreen() {
        D2.SetActive(true);
        D1.SetActive(false);
        Debug.Log("display3 nyala");
    }

    // Update is called once per frame
    void Update()
    {
        
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
