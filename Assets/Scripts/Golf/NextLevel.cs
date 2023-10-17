using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{
    public class NextLevel : MonoBehaviour
    {
        [SerializeField] GameObject level1;
        [SerializeField] GameObject level2;

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Stone")
            {
                level1.SetActive(false);
                level2.SetActive(true);
            }
        }
    }
}
