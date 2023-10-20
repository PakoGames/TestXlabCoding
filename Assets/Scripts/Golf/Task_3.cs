using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{
    public class Task_3 : MonoBehaviour
    {
        #region ������ ���������� ��� ������ ������
        public float x, y, z;
        [SerializeField] GameObject stone;
        private Vector3 whereToSpawn;
        #endregion

        //������� ������ �������.
        public GameObject SpawnStone()
        {
            whereToSpawn = new Vector3(x, y, z);
            GameObject sp = Instantiate(stone, whereToSpawn, Quaternion.identity);
            return sp;

        }



    }
}