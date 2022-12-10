using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour
{
    public int targetEvent = -1;    //defult == -1
    public GameObject Score;
    public SpriteRenderer textBoxBackRender;

    private void Update()
    {
        Debug.Log(targetEvent);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Item") //�����۰� �浹 ��
        {
            if (collision.gameObject.GetComponent<ItemController>().itemNum == targetEvent) //���� �̺�Ʈ�� �ش��ϴ� �����۰� �浹 ��
            {
                Score.GetComponent<Score>().score += 10;
                textBoxBackRender.enabled = false;
            }
        }

        Destroy(collision.gameObject);  //������ ����
    }
}
