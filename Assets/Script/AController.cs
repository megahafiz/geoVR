using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AController : MonoBehaviour
{
    Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void Play()
    {
        anim.SetBool("isgerak", true);
    }
}
