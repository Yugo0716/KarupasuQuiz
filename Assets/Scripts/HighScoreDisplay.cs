using ProcRanking;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class HighScoreDisplay : MonoBehaviour
{
    [SerializeField] GameObject[] highScoreTexts = new GameObject[10];
    float[] highScores = new float[10];
    float time;

    [SerializeField] GameObject yourTimeTextObj;
    Text yourTimeText;


    // Start is called before the first frame update
    void Start()
    {
        time = ScoreManager.time;
        yourTimeText = yourTimeTextObj.GetComponent<Text>();

        if (ScoreManager.isCorrect)
        {
            if(SceneManager.GetActiveScene().name == "Title")
            {
                yourTimeText.text = "目指せ10点満点!";
            }
            else
            {                
                yourTimeText.text = "自分のタイム：" + time.ToString("N2") + "秒";
            }
            
        }
        else
        {
            yourTimeText.text = "目指せ10点満点!";
        }

        

        if (ScoreManager.isCorrect && SceneManager.GetActiveScene().name != "Title")
        {
            time.SaveToProcRaAsync("KarupasuDataStore", "time");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HighScoreLoad()
    {
        var query = new ProcRaQuery<ProcRaData>("KarupasuDataStore")
            .SetLimit(10)
            .SetAscSort("time");

        query.FindAsync((List<ProcRaData> foundList, ProcRaException e) =>
        {
            if (e != null)
            {
                // エラー発生時の処理
            }
            else
            {
                // 検索成功時の処理例
                for (int i = 0; i < foundList.Count; i++)
                {

                    //32ビットfloatへキャスト
                    highScores[i] = Convert.ToSingle(foundList[i]["time"]);

                    //スコアをテキスト表示
                    highScoreTexts[i].GetComponent<Text>().text = highScores[i].ToString("N2") + "秒";

                }
            }
        });
    }
}
