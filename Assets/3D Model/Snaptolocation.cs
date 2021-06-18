using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snaptolocation : MonoBehaviour
{
    //bollean variable used to determine if the obkect is currently being held by the player
    //private bool grabbed;

    //return true when the object is within the snapZone radius
   // private bool insideSnapZone;

    //return true when the object has had it's location updated
    ///public bool snapped;

    //set the specific part we want to snap to this location
   // public GameObject penyambung;

    //Reference another object we can use to set rotation
   // public GameObject SnapRotationReference;

    //Detects when RocketPart game object has entered the snap zone radius

   // private void OnTriggerEnter(Collider other)
    //{
      //  if (other.gameObject.name == penyambung.name)
      //  {
           // insideSnapZone = true;
       // }
    //}

    //Detects when RocketPart game object has entered the snap zone radius

    //private void OnTriggerExit(Collider other)
   // {
       // if (other.gameObject.name == penyambung.name)
        //{
           // insideSnapZone = false;
        //}
   // }

    //Check if the player has released the object AND if the object is within the SnapZone radius
    //if both are true, sets the object location and rotation to the desired snap coordinates
    //Sets the public boolean Snapped to true for referece by SnapObject script

    //void SnapObject()
   // {
     //   if (grabbed == false && insideSnapZone == true)
      //  {
          //  penyambung.gameObject.transform.position = transform.position;
            //penyambung.gameObject.transform.rotation = SnapRotationReference.transform.rotation;
       //     snapped = true;
       // }
    //}

    // Update is called once per frame
   // void Update()
    //{
        //Set grabbed to equel the boolean value "isGrabbed" from the OVRGrabble script
       // grabbed = penyambung.GetComponent<OVRGrabble>().isGrabbed;
        //call our snap object script
       // SnapObject();
    //}
}
