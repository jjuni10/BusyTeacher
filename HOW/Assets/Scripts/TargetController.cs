using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour
{
    public int targetEvent = -1;    //defult == -1
    public GameManager gameManager;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Item") //아이템과 충돌 시
        {
            if (collision.gameObject.GetComponent<ItemController>().itemNum == targetEvent) //현재 이벤트에 해당하는 아이템과 충돌 시
                GameManager.score += 10;
        }

        Destroy(collision.gameObject);  //아이템 삭제
    }
}
