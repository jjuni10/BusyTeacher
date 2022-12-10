using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextboxContoller : MonoBehaviour
{
    public Transform cameraTrans;
    public SpriteRenderer childBackRender;
    public SpriteRenderer ChildForeRender;
    public Sprite[] foreGrounds;

    public GameObject Target;

    float spawnTime = 5f;
    float currentTime = 0;

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(cameraTrans);  //빌보드

        spawn();
        Debug.Log(currentTime);
        Debug.Log(childBackRender.enabled);
    }

    void spawn()
    {
        if (!childBackRender.enabled) //비활성화 상태 시 스폰시키기
        {
            if (currentTime > spawnTime)    //스폰 시간마다 활성화   
            {
                currentTime = 0;

                childBackRender.enabled = true; //배경이미지 출력
                int rand = Random.Range(0, 4);
                Target.GetComponent<TargetController>().targetEvent = rand;
                ChildForeRender.sprite = foreGrounds[rand];    //아이콘이미지 랜덤 출력
                ChildForeRender.enabled = true;
            }

            currentTime += Time.deltaTime;
        }
    }
}
