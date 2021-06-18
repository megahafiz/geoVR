using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Next1819 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Display;
    public GameObject D18, D19;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void nextScreen18()
    {
        D19.SetActive(true);
        D18.SetActive(false);
        Debug.Log("display3 nyala");
    }
        // private void OnTriggerEnter(Collider other)
        //   {
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
