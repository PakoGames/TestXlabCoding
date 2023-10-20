using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{
    public class NextLevel : MonoBehaviour
    {
        public LevelController levelController;
        public int count = 1;

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Stone")
            {
                //count++;
                levelController.countLevel ++;
            }
        }
    }
}
