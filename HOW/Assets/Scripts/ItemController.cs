using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    public int itemNum; //�����ۿ� �ش��ϴ� ���� �ο�
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
        if (collision.gameObject.tag == "Floor") //�ٴڰ� �浹 ��
        {
            Destroy(gameObject);
        }
    }
}
