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

    float spawnTime = 1f;
    float currentTime = 0;

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(cameraTrans);  //������

        if (childBackRender.enabled == false)
            ChildForeRender.enabled = false;

        spawn();
    }

    void spawn()
    {
        if (!childBackRender.enabled) //��Ȱ��ȭ ���� �� ������Ű��
        {
            if (currentTime > spawnTime)    //���� �ð����� Ȱ��ȭ   
            {
                currentTime = 0;

                childBackRender.enabled = true; //����̹��� ���
                int rand = Random.Range(0, 3);
                Target.GetComponent<TargetController>().targetEvent = rand;
                ChildForeRender.sprite = foreGrounds[rand];    //�������̹��� ���� ���
                ChildForeRender.enabled = true;
            }
            currentTime += Time.deltaTime;
        }
    }
}
