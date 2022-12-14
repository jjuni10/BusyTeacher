using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    //��ŷ ���� ���� �迭
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
        timer.text = ("�ð� :" + Mathf.Round(time));

        if(time<=0)
        {
            ScoreSet(score_cs.GetComponent<Score>().score);
            SceneManager.LoadScene("GameOver");
        }
    }

    public void ScoreSet(int currentScore)
    {
        //���� ������ ����
        PlayerPrefs.SetInt("CurrentPlayerScore", currentScore);
        //�ӽ� ���庯��
        int tmpScore = 0;

        //��ŷ��ŭ �ݺ�
        for (int i = 0; i < bestScore.Length; i++)
        {
            //����� ������ ��������
            bestScore[i] = PlayerPrefs.GetInt(i + "BestScore");

            //���� ������ ����� �������� ������
            while (bestScore[i] < currentScore)
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

        for (int i = 0; i < bestScore.Length; i++)
        {
            //��ŷ ����
            PlayerPrefs.SetInt(i + "BestScore", bestScore[i]);
        }
    }
}
