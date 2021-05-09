﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demolition_Collision : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D col)
    {

        //충돌체의 태그가 First일때, 충돌체와 함께 파괴되고 Second_Cube를 First_Cube로 바꿉니다.
        if (col.gameObject.tag == "First")
        {
            Destroy(this.gameObject);
            Destroy(col.gameObject);

            //twin으로 만들어진 First 큐브는 2개이므로 2개의 큐브를 제거합니다.
            if(GameObject.FindWithTag("First")!=null)
            {
                GameObject[] Destroyed_Object = GameObject.FindGameObjectsWithTag("First");

                for(int count =0; count<Destroyed_Object.Length;count++)
                    Destroy(Destroyed_Object[count]);
            }

            GameObject[] temp;
            temp = GameObject.FindGameObjectsWithTag("Second");

            temp[temp.Length-1].gameObject.tag = ("First");
        }

        //충돌체의 태그가 Second일때,  충돌체와 함께 파괴됩니다.
        else if (col.gameObject.tag == "Second")
        {
            Destroy(this.gameObject);
            Destroy(col.gameObject);
        }
    }
}