using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Stone")
        {
            Debug.Log("Удар!!!");
        }
    }

}
