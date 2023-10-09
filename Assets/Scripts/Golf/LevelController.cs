using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Golf
{


    public class LevelController : MonoBehaviour
    {
        public Task_3 spawner;
        public bool isGameOver = false;
        public float delay = 0.5f;

        private void Start()
        {
            StartCoroutine(SpawnStoneProc());
        }

        private IEnumerator SpawnStoneProc()
        {
            do
            {
                yield return new WaitForSeconds(delay);

                spawner.SpawnStone();
            }
            while (!isGameOver);
            


           
        }
    }
}
