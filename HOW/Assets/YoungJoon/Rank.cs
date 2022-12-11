using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rank : MonoBehaviour
{
    //랭킹 점수 저장 배열
    public int[] bestScore = new int[5];

    //현재 점수 출력 text UI
    public Text RankScoreCurrent;

    //랭킹 점수 출력 배열
    public int[] rankScore =new int[5];

    //랭킹 점수 출력 text UI
    public Text[] rankScoreText=new Text[5];

    public void ScorePrint()
    {
        //텍스트UI에 출력
        RankScoreCurrent.text = string.Format("{0}점", PlayerPrefs.GetInt("CurrentPlayerScore"));

        //랭킹에 맞춰 점수를 불러오고, 이를 출력함
        for(int i = 0; i < bestScore.Length; i++)
        {
            rankScore[i] = PlayerPrefs.GetInt(i + "BestScore");
            rankScoreText[i].text = string.Format("{0}점", rankScore[i]);
        }
    }


    public void ScoreSet(int currentScore)
    {
        //현재 점수를 저장
        PlayerPrefs.SetInt("CurrentPlayerScore", currentScore);
        //임시 저장변수
        int tmpScore = 0;

        //랭킹만큼 반복
        for(int i=0; i < bestScore.Length; i++)
        {
            //저장된 점수를 가져오기
            bestScore[i] = PlayerPrefs.GetInt(i + "BestScore");
            
            //현재 점수가 저장된 점수보다 높으면
            while(bestScore[i] < currentScore)
            {
                //점수 교체
                tmpScore = bestScore[i];
                bestScore[i] = currentScore;

                //랭킹에 저장
                PlayerPrefs.SetInt(i + "BestScore", currentScore);

                //밀린 점수를 현재 점수로 저장해 내림차순 정렬 작동
                currentScore = tmpScore;
            }
        }

        for(int i=0; i < bestScore.Length; i++)
        {
            //랭킹 저장
            PlayerPrefs.SetInt(i + "BestScore", bestScore[i]);
        }
    }
}
