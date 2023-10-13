using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private Hit hit;

        void Start()
        {
            if (hit == null)
            {
                Debug.Log("Hit is NULLLLLLLL!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            }
        }

    }
}
