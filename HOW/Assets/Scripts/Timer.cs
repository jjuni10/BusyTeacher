using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    //랭킹 점수 저장 배열
    public int[] bestScore = new int[3];
    public GameObject score_cs;

    public float time;
    public Text timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        timer.text = ("시간 :" + Mathf.Round(time));

        if(time<=0)
        {
            ScoreSet(score_cs.GetComponent<Score>().score);
            SceneManager.LoadScene("GameOver");
        }
    }

    public void ScoreSet(int currentScore)
    {
        //현재 점수를 저장
        PlayerPrefs.SetInt("CurrentPlayerScore", currentScore);
        //임시 저장변수
        int tmpScore = 0;

        //랭킹만큼 반복
        for (int i = 0; i < bestScore.Length; i++)
        {
            //저장된 점수를 가져오기
            bestScore[i] = PlayerPrefs.GetInt(i + "BestScore");

            //현재 점수가 저장된 점수보다 높으면
            while (bestScore[i] < currentScore)
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

        for (int i = 0; i < bestScore.Length; i++)
        {
            //랭킹 저장
            PlayerPrefs.SetInt(i + "BestScore", bestScore[i]);
        }
    }
}
