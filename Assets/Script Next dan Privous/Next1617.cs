using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Next1617 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Display;
    public GameObject D16, D17;
    public GameObject isi;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void nextScreen16()
    {
        Displaymanager.configuration_content = isi.GetComponent<UnityEngine.UI.Text>().text;
        Debug.Log("isi file conf"+ Displaymanager.configuration_content);
      //  Debug.Log("isi file conf" + );
        D17.SetActive(true);
        D16.SetActive(false);
        Debug.Log("display3 nyala");
    }
        //private void OnTriggerEnter(Collider other)
    //{
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
   // }
}
