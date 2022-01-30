using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ScoreScript : MonoBehaviour
{
    private GameObject scoreText;
    // Start is called before the first frame update
    public void Start()
    {
        this.scoreText = GameObject.Find("ScoreText");//scoreTextにScoreTextを入れる
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision other)
    {
        string score = this.scoreText.GetComponent<Text>().text;//textを取得してscore変数に
        int Score = Convert.ToInt32(score);//Score変数にscoreの中身を数値にして入れる

        if (other.gameObject.tag == "SmallStarTag")
        {
            Score += 5;//Scoreに得点を追加
            this.scoreText.GetComponent<Text>().text= Convert.ToString(Score);//Textに文字列に変換したScoreの中身を入れる
        }
        else if(other.gameObject.tag == "SmallCloudTag" || tag == "LargeStarTag")
        {
            Score += 10;//Scoreに得点を追加
            this.scoreText.GetComponent<Text>().text = Convert.ToString(Score);//Textに文字列に変換したScoreの中身を入れる
        }
        else if (other.gameObject.tag == "LargeCloudTag")
        {
            Score += 20;//Scoreに得点を追加
            this.scoreText.GetComponent<Text>().text = Convert.ToString(Score);//Textに文字列に変換したScoreの中身を入れる
        }
    }
}
