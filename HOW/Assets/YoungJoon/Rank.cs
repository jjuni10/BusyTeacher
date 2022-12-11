using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rank : MonoBehaviour
{
    //��ŷ ���� ���� �迭
    public int[] bestScore = new int[5];

    //���� ���� ��� text UI
    public Text RankScoreCurrent;

    //��ŷ ���� ��� �迭
    public int[] rankScore =new int[5];

    //��ŷ ���� ��� text UI
    public Text[] rankScoreText=new Text[5];

    public void ScorePrint()
    {
        //�ؽ�ƮUI�� ���
        RankScoreCurrent.text = string.Format("{0}��", PlayerPrefs.GetInt("CurrentPlayerScore"));

        //��ŷ�� ���� ������ �ҷ�����, �̸� �����
        for(int i = 0; i < bestScore.Length; i++)
        {
            rankScore[i] = PlayerPrefs.GetInt(i + "BestScore");
            rankScoreText[i].text = string.Format("{0}��", rankScore[i]);
        }
    }


    public void ScoreSet(int currentScore)
    {
        //���� ������ ����
        PlayerPrefs.SetInt("CurrentPlayerScore", currentScore);
        //�ӽ� ���庯��
        int tmpScore = 0;

        //��ŷ��ŭ �ݺ�
        for(int i=0; i < bestScore.Length; i++)
        {
            //����� ������ ��������
            bestScore[i] = PlayerPrefs.GetInt(i + "BestScore");
            
            //���� ������ ����� �������� ������
            while(bestScore[i] < currentScore)
            {
                //���� ��ü
                tmpScore = bestScore[i];
                bestScore[i] = currentScore;

                //��ŷ�� ����
                PlayerPrefs.SetInt(i + "BestScore", currentScore);

                //�и� ������ ���� ������ ������ �������� ���� �۵�
                currentScore = tmpScore;
            }
        }

        for(int i=0; i < bestScore.Length; i++)
        {
            //��ŷ ����
            PlayerPrefs.SetInt(i + "BestScore", bestScore[i]);
        }
    }
}
