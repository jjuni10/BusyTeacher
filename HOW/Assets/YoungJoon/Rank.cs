using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rank : MonoBehaviour
{
    //��ŷ ���� ���� �迭
    public int[] bestScore = new int[3];

    //���� ���� ��� text UI
    public Text RankScoreCurrent;

    //��ŷ ���� ��� �迭
    public int[] rankScore =new int[3];

    //��ŷ ���� ��� text UI
    public Text[] rankScoreText=new Text[3];

    private void Start()
    {
        ScorePrint();
    }

    public void ScorePrint()
    {
        //�ؽ�ƮUI�� ���
        RankScoreCurrent.text = string.Format("My Score : {0}��", PlayerPrefs.GetInt("CurrentPlayerScore"));

        //��ŷ�� ���� ������ �ҷ�����, �̸� �����
        for(int i = 0; i < bestScore.Length; i++)
        {
            rankScore[i] = PlayerPrefs.GetInt(i + "BestScore");
            rankScoreText[i].text += string.Format("{0}��\n", rankScore[i]);
        }
    }



}
