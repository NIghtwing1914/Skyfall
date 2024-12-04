using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punch : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource smash;

    public bool smashing = false;
    public void OnTriggerEnter(Collider other)
    {
        if (smashing)
        {
            smash.Play();
        }
    }

    
}
