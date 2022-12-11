using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    public int itemNum; //아이템에 해당하는 숫자 부여
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
 
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor") //바닥과 충돌 시
        {
            Destroy(gameObject);
        }
    }
}
