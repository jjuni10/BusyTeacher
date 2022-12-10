using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjGenerator : MonoBehaviour
{
    public GameObject [] Obj;
    public GameObject[] Obj_Prefab;
    public Transform [] offset;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < Obj.Length; i++)
        {
            offset[i] = Obj[i].transform;
            Debug.Log(offset[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < Obj.Length; i++)
        {
            if (Obj[i]==null)
            {
                Obj[i]=Instantiate(Obj_Prefab[i], offset[i]);
            }
        }
    }
}
