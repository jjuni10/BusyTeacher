using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rank : MonoBehaviour
{
    //랭킹 점수 저장 배열
    public int[] bestScore = new int[3];

    //현재 점수 출력 text UI
    public Text RankScoreCurrent;

    //랭킹 점수 출력 배열
    public int[] rankScore =new int[3];

    //랭킹 점수 출력 text UI
    public Text[] rankScoreText=new Text[3];

    private void Start()
    {
        ScorePrint();
    }

    public void ScorePrint()
    {
        //텍스트UI에 출력
        RankScoreCurrent.text = string.Format("My Score : {0}점", PlayerPrefs.GetInt("CurrentPlayerScore"));

        //랭킹에 맞춰 점수를 불러오고, 이를 출력함
        for(int i = 0; i < bestScore.Length; i++)
        {
            rankScore[i] = PlayerPrefs.GetInt(i + "BestScore");
            rankScoreText[i].text += string.Format("{0}점\n", rankScore[i]);
        }
    }



}
