using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator Display;

    void Start()
    {
        
    }
    public void Show ()
    {
        //isplay.Play("sokkapenyambung");
        Display.SetBool("isgerak", true);
       Debug.Log("tes show");
    }
    // Update is called once per frame
    void Update()
    {
        
    }

}
