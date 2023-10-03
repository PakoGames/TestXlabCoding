using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TestXlab
{

    public class PlayerController : MonoBehaviour
    {
        public Spawner spawner;
        private void Update()
        {

            if (Input.GetKeyDown(KeyCode.X))
            {
                Debug.Log(" амень упал");
                spawner.Spawners();
            }

            if (Input.GetKeyDown(KeyCode.Z))
            {
                Debug.Log("дождь поехал");
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("мен€ем инструмент");
            }
        }
    }

}