using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int score = 0;
    public Text UIScore;
    void Update()
    {
        UIScore.text = ("SCORE :" + score);
    }
}
