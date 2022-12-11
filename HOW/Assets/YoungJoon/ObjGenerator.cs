using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjGenerator : MonoBehaviour
{
    public GameObject parents;
    public GameObject [] obj;
    public GameObject[] obj_prefab;
    public Transform [] offset;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < obj.Length; i++)
        {
            offset[i] = obj[i].transform;
            Debug.Log(offset[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < obj.Length; i++)
        {
            if (obj[i]==null)
            {
                obj[i]=Instantiate(obj_prefab[i], offset[i]);
                obj[i].transform.parent = parents.transform;
            }
        }
    }
}
