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
        this.scoreText = GameObject.Find("ScoreText");//scoreText��ScoreText������
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision other)
    {
        string score = this.scoreText.GetComponent<Text>().text;//text���擾����score�ϐ���
        int Score = Convert.ToInt32(score);//Score�ϐ���score�̒��g�𐔒l�ɂ��ē����

        if (other.gameObject.tag == "SmallStarTag")
        {
            Score += 5;//Score�ɓ��_��ǉ�
            this.scoreText.GetComponent<Text>().text= Convert.ToString(Score);//Text�ɕ�����ɕϊ�����Score�̒��g������
        }
        else if(other.gameObject.tag == "SmallCloudTag" || tag == "LargeStarTag")
        {
            Score += 10;//Score�ɓ��_��ǉ�
            this.scoreText.GetComponent<Text>().text = Convert.ToString(Score);//Text�ɕ�����ɕϊ�����Score�̒��g������
        }
        else if (other.gameObject.tag == "LargeCloudTag")
        {
            Score += 20;//Score�ɓ��_��ǉ�
            this.scoreText.GetComponent<Text>().text = Convert.ToString(Score);//Text�ɕ�����ɕϊ�����Score�̒��g������
        }
    }
}
