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
                Debug.Log("������ ����");
                spawner.Spawners();
            }

            if (Input.GetKeyDown(KeyCode.Z))
            {
                Debug.Log("����� ������");
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("������ ����������");
            }
        }
    }

}