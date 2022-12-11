using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour
{
    public int targetEvent = -1;    //defult == -1
    public GameObject Score;
    public SpriteRenderer textBoxBackRender;
    public SpriteRenderer textBoxForeRender;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Item") //�����۰� �浹 ��
        {
            Debug.Log("�±� �ν�");
            Debug.Log(collision.gameObject.GetComponent<ItemController>().itemNum + ":" + targetEvent);
            if (collision.gameObject.GetComponent<ItemController>().itemNum == targetEvent) //���� �̺�Ʈ�� �ش��ϴ� �����۰� �浹 ��
            {
                Debug.Log("�̺�Ʈ �ѹ�");
                Score.GetComponent<Score>().score += 10;
                textBoxBackRender.enabled = false;
                textBoxForeRender.enabled = false;
            }
        }
        if(collision.gameObject.tag != "Floor")
            Destroy(collision.gameObject);  //������ ����
    }
}
