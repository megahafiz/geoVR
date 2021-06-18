using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button1 : MonoBehaviour
{
    public Animator Display;

    void Start()
    {

    }
    public void Show()
    {
        //isplay.Play("sokkapenyambung");
        Display.SetBool("isgerak", true);
        Debug.Log("tes show");
    }
    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        Show();
    }
}
