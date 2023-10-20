using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{
    public class Hit : MonoBehaviour
    {
        public delegate void OnTouchDelegate();
        public static event OnTouchDelegate OnTouch;
        public BallFlight fly;

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "Stone")
            {
                fly.rock = collision.transform.gameObject;
                Debug.Log("Удар!!!");
                fly.hitr();
                OnTouch?.Invoke();
            }
        }


    }
}