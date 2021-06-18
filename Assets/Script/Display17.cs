using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Display17 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Text myText = this.AddComponent<Text>();
        //myText.text = "";
        this.GetComponent<UnityEngine.UI.Text>().text = Displaymanager.configuration_content;
        //this.GetComponent.GetComponent<UnityEngine.UI.Text>.text = 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
