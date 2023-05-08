using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BallController : MonoBehaviour
{

    //ボールが見える可能性のあるz軸の最小値
    private float visiblePosZ = -6.5f;

    //ゲームオーバーを表示するテキスト
    private GameObject gameoverText;
    
    //点数用の変数
    private int score = 0;

    //scoreを表示するテキスト
    private GameObject scoreText;

    // Start is called before the first frame update
    void Start()
    {

        //シーンの中のGameOverTextオブジェクトを取得
        this.gameoverText = GameObject.Find("GameOverText");
        //シーンの中のScoreオブジェクトを取得
        this.scoreText = GameObject.Find("Score");
    }

    // Update is called once per frame
    void Update()
    {
        
        //ボールが画面外に出た場合
        if (this.transform.position.z < this.visiblePosZ)
        {

            //GameoverTextにゲームオーバーを表示
            this.gameoverText.GetComponent<Text>().text = "Game Over";

        }
    }
    void OnCollisionEnter(Collision other)
    {
        //SmallStarのスコア
        if (other.gameObject.tag == "SmallStarTag")
        {
            score += 10;
        }

        //LargeStarのスコア
        if (other.gameObject.tag == "LargeStarTag")
        {
            score += 40;
        }

        //SmallCloudのスコア
        if (other.gameObject.tag == "SmallCloudTag")
        {
            score += 30;
        }

        //LargeCloudのスコア
        if (other.gameObject.tag == "LargeCloudTag")
        {
            score += 50;
        }
        Debug.Log("衝突 " + other.gameObject.tag);
        //scoreTextにスコアを表示
        this.scoreText.GetComponent<Text>().text = "Score " + score;
    }

}
