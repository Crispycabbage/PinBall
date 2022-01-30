using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FripperController : MonoBehaviour
{
    private HingeJoint myHingeJoint;//空のhingejoint型を宣言？
    private float defaultAngle = 20;
    private float flickAngle = -20;

    // Start is called before the first frame update
    void Start()
    {
        this.myHingeJoint = GetComponent<HingeJoint>();//代入
        SetAngle(this.defaultAngle);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) && tag == "LeftFripperTag"|| 
            Input.GetKeyDown(KeyCode.A) && tag == "LeftFripperTag"|| 
            Input.GetKeyDown(KeyCode.S) && tag == "LeftFripperTag"||
            Input.GetKeyDown(KeyCode.DownArrow) && tag == "LeftFripperTag" )
        {
            SetAngle(this.flickAngle);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) && tag == "RightFripperTag"||
            Input.GetKeyDown(KeyCode.D) && tag == "RightFripperTag" ||
            Input.GetKeyDown(KeyCode.S) && tag == "RightFripperTag" ||
            Input.GetKeyDown(KeyCode.DownArrow) && tag == "RightFripperTag")
        {
            SetAngle(this.flickAngle);
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow) && tag == "LeftFripperTag"||
            Input.GetKeyUp(KeyCode.A) && tag == "LeftFripperTag"||
            Input.GetKeyUp(KeyCode.S) && tag == "LeftFripperTag"||
            Input.GetKeyUp(KeyCode.DownArrow) && tag == "LeftFripperTag")
        {
            SetAngle(this.defaultAngle);
        }
        if (Input.GetKeyUp(KeyCode.RightArrow) && tag == "RightFripperTag"||
            Input.GetKeyUp(KeyCode.D) && tag == "RightFripperTag" ||
            Input.GetKeyUp(KeyCode.S) && tag == "RightFripperTag"||
            Input.GetKeyUp(KeyCode.DownArrow) && tag == "RightFripperTag")
        {
            SetAngle(this.defaultAngle);
        }

    }
    private void SetAngle(float angle)
    {
        JointSpring jointspr = this.myHingeJoint.spring;
        jointspr.targetPosition = angle;
        this.myHingeJoint.spring = jointspr;
    }
    int unko = 1;
}
