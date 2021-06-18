using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Next3738 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Display;
    public GameObject D37, D38;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

     public void nextScreen37()
    {
        D38.SetActive(true);
        D37.SetActive(false);
        Debug.Log("display37 nyala");
    }

    /*private void OnTriggerEnter(Collider other)
    {
        //if (other.tag == "player")
        //{
        //   Display.Find("DISPLAY2").SetActive(true);
        //  Display.Find("DISPLAY1").SetActive(false);
        //  D2= Display.transform.Find("DISPLAY2").GetComponent <GameObject>();
        // D1 =Display.transform.Find("DISPLAY1").GetComponent<GameObject>();
        D38.SetActive(true);
        D37.SetActive(false);
        Debug.Log("display3 nyala");

        // }
        //else
        //{
        //  Debug.Log("tag="+other.tag);

        // }
    }*/
}
