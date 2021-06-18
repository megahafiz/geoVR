using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class penyambung1 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject penyambung;
    bool kena = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (kena==true)
        {
            snap_objek();
        }
       
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("penyambung")) 
        {
            //  this.transform.position = penyambung.transform.position;
            kena = true;
            
           /* Debug.Log("penyambung1 posisi x"+this.transform.position.x);
            Debug.Log("penyambung1 posisi y" + this.transform.position.y);
            Debug.Log("penyambung1 posisi z" + this.transform.position.z);
            Debug.Log("penyambung posisi x"+ penyambung.transform.position.x);
            Debug.Log("penyambung posisi y"+ penyambung.transform.position.y);
            Debug.Log("penyambung posisi z"+ penyambung.transform.position.z);
                        Debug.Log("kena posisi");*/
        }
    }
    private void snap_objek()
    {
        this.transform.position = penyambung.transform.position;
    }
}
