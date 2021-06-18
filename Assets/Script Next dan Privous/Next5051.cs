using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Next5051 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Display;
    public GameObject D50, D51;
    public bool isClicked = false;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
     public void nextScreen50()
    {
        D51.SetActive(true);
        D50.SetActive(false);
        Debug.Log("display50 nyala");
    }

    /*private void OnTriggerEnter(Collider other)
    {
        //if (other.tag == "player")
        //{
        //   Display.Find("DISPLAY2").SetActive(true);
        //  Display.Find("DISPLAY1").SetActive(false);
        //  D2= Display.transform.Find("DISPLAY2").GetComponent <GameObject>();
        // D1 =Display.transform.Find("DISPLAY1").GetComponent<GameObject>();

        if (isClicked == false) {
            D51.SetActive(true);
            D50.SetActive(false);
            Debug.Log("display3 nyala");
            isClicked = true;
        }
        
        

        // }
        //else
        //{
        //  Debug.Log("tag="+other.tag);

        // }
    }

    private void OnTriggerExit(Collider other)
    {
        isClicked = false;
    }*/
}
