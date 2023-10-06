using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TestXlab
{

    public class PlayerController : MonoBehaviour
    {
        public Task_3 stone;
        public Task_3_Rain_Run Rain;
        public Task_3_Tools changeTools;
        private void Update()
        {

            if (Input.GetKeyDown(KeyCode.X))
            {
                Debug.Log("������ ����");
                stone.SpawnStone();
                
            }

            if (Input.GetKeyDown(KeyCode.Z))
            {
                Debug.Log("����� ������");
                Rain.RainRun();
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("������ ����������");
                changeTools.ChangeTools();
            }
        }
    }

}