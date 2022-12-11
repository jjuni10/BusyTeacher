using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour
{
    public int targetEvent = -1;    //defult == -1
    public GameObject Score;
    public SpriteRenderer textBoxBackRender;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("충돌 인식");
        if (collision.gameObject.tag == "Item") //아이템과 충돌 시
        {
            Debug.Log("태그 인식");
            Debug.Log(collision.gameObject.GetComponent<ItemController>().itemNum + ":" + targetEvent);
            if (collision.gameObject.GetComponent<ItemController>().itemNum == targetEvent) //현재 이벤트에 해당하는 아이템과 충돌 시
            {
                Debug.Log("이벤트 넘버");
                Score.GetComponent<Score>().score += 10;
                textBoxBackRender.enabled = false;
            }
        }
        if(collision.gameObject.tag != "Floor")
            Destroy(collision.gameObject);  //아이템 삭제
    }
}
