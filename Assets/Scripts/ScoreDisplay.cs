using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    [SerializeField] GameObject scoreObject;
    Text scoreText;

    [SerializeField] GameObject timeObject;
    Text timeText;

    string comment;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = scoreObject.GetComponent<Text>();
        timeText = timeObject.GetComponent<Text>();

        if (ScoreManager.score <= 0) comment = "逆にすごい!!!!";
        else if (ScoreManager.score <= 3) comment = "もっとカルパスに詳しくなろう";
        else if (ScoreManager.score <= 6) comment = "まあまあだね";
        else if (ScoreManager.score <= 9) comment = "プロのおやつカルパス鑑定士";
        else if (ScoreManager.score <= 10) comment = "もはやカルパスを統べる存在";

        scoreText.text = "10問中　" + ScoreManager.score + "　問正解!\n\n" + comment;

        if(ScoreManager.isCorrect)
        {
            timeObject.SetActive(true);
            timeText.text = "クリアタイム：" + ScoreManager.time.ToString("N2") + "秒！！";
        }
        else
        {
            timeObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
