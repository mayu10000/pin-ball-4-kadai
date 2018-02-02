using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoreplus : MonoBehaviour
{


    //  score 追加
    private GameObject stateText;
    //スコアを表示するテキスト（追加）
    private GameObject scoreText;
    //得点（追加）
    private int score = 0;
    //  ここまで




    // Use this for initialization
    void Start()
    {

        //  score  追加分
        //シーン中のscoreTextオブジェクトを取得（追加）
        this.scoreText = GameObject.Find("ScoreText");
        //  ここまで
        
    }



    // Update is called once per frame
    void Update()
    {

    }

    //トリガーモードで他のオブジェクトと接触した場合の処理
    // void OnTriggerEnter(Collider other)
    // {
    //        ｝
    // }


    private void OnCollisionEnter(Collision other)  //*追加
    {


        //雲小に衝突した場合
        if (other.gameObject.tag == "SmallCloudTag")

        {
            if (tag == "SmallCloudTag")    // ここ間違い　上に

                //  {
                // スコアを加算(追加)
                this.score += 10;



            //ScoreText獲得した点数を表示(追加)
            //this.scoreText.GetComponent<Text>().text = "Score " + this.score + "pt";
        }


        //雲大に衝突した場合
        // if (other.gameObject.tag == "LargeCloudTag")  //ここ間違い

        else if (other.gameObject.tag == "LargeCloudTag")  // else が必要？な理由？


        {
            // スコアを加算(追加)
            this.score += 25;

        }


            //ScoreText獲得した点数を表示(追加)
            this.scoreText.GetComponent<Text>().text = "Score " + this.score + "pt";


            //  }
          }
       }
    