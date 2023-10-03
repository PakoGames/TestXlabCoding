using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task_3_Tools : MonoBehaviour

{
    public int people; 
    public MeshFilter[] changeMesh;
    public Mesh[] WhatChenge;
    private int Tools;
    private int index;

    void ChangeTools()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (index = 0; index < people; index++)
            {
                Tools = Random.Range(0, WhatChenge.Length);
                changeMesh[index].mesh = WhatChenge[Tools];
            }
            
        }
    }

    void Update()
    {
        ChangeTools();
    }
}
