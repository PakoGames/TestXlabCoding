using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallFlight : MonoBehaviour
{
    public float spead;
    public GameObject rock;

    public void hitr()
    {
        rock.GetComponent<Rigidbody>().velocity = transform.forward * spead;
    }
}
