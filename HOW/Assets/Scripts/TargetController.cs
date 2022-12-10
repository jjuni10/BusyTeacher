using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour
{
    public int targetEvent = -1;    //defult == -1
    public GameManager gameManager;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Item") //�����۰� �浹 ��
        {
            if (collision.gameObject.GetComponent<ItemController>().itemNum == targetEvent) //���� �̺�Ʈ�� �ش��ϴ� �����۰� �浹 ��
                GameManager.score += 10;
        }

        Destroy(collision.gameObject);  //������ ����
    }
}
