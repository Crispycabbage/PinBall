using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudController : MonoBehaviour
{
    private float minimum = 1.0f;//�ŏ��T�C�Y
    private float magSpeed = 10.0f;//�g��k���X�s�[�h
    private float magnification = 0.07f;//�g�嗦
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.localScale =
            new Vector3(
            this.minimum + Mathf.Sin(Time.time * this.magSpeed) * this.magnification,
            this.transform.localScale.y,
            this.minimum + Mathf.Sin(Time.time * this.magSpeed) * this.magnification
            );
    }
}
