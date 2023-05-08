using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BallController : MonoBehaviour
{

    //�{�[����������\���̂���z���̍ŏ��l
    private float visiblePosZ = -6.5f;

    //�Q�[���I�[�o�[��\������e�L�X�g
    private GameObject gameoverText;
    
    //�_���p�̕ϐ�
    private int score = 0;

    //score��\������e�L�X�g
    private GameObject scoreText;

    // Start is called before the first frame update
    void Start()
    {

        //�V�[���̒���GameOverText�I�u�W�F�N�g���擾
        this.gameoverText = GameObject.Find("GameOverText");
        //�V�[���̒���Score�I�u�W�F�N�g���擾
        this.scoreText = GameObject.Find("Score");
    }

    // Update is called once per frame
    void Update()
    {
        
        //�{�[������ʊO�ɏo���ꍇ
        if (this.transform.position.z < this.visiblePosZ)
        {

            //GameoverText�ɃQ�[���I�[�o�[��\��
            this.gameoverText.GetComponent<Text>().text = "Game Over";

        }
    }
    void OnCollisionEnter(Collision other)
    {
        //SmallStar�̃X�R�A
        if (other.gameObject.tag == "SmallStarTag")
        {
            score += 10;
        }

        //LargeStar�̃X�R�A
        if (other.gameObject.tag == "LargeStarTag")
        {
            score += 40;
        }

        //SmallCloud�̃X�R�A
        if (other.gameObject.tag == "SmallCloudTag")
        {
            score += 30;
        }

        //LargeCloud�̃X�R�A
        if (other.gameObject.tag == "LargeCloudTag")
        {
            score += 50;
        }
        Debug.Log("�Փ� " + other.gameObject.tag);
        //scoreText�ɃX�R�A��\��
        this.scoreText.GetComponent<Text>().text = "Score " + score;
    }

}
