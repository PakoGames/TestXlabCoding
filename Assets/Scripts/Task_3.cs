using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task_3 : MonoBehaviour
{
    #region ������ ���������� ��� ������ ������
    public float x, y, z;
    [SerializeField] GameObject stone;
    private Vector3 whereToSpawn;
    #endregion

    //������� ������ �������.
    public void SpawnStone()
    {
        whereToSpawn = new Vector3(x, y, z);
        Destroy(Instantiate(stone, whereToSpawn, Quaternion.identity), 10);
    }


   
}
