using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiceManager : MonoBehaviour
{
    public bool oyatsu; //問題の画像がおやつカルパスならtrue
    public GameObject quizManagerObj;
    QuizManager quizManager;

    public GameObject videoControllerObj;
    VideoController videoController;

    // Start is called before the first frame update
    void Start()
    {
        quizManager = quizManagerObj.GetComponent<QuizManager>();
        videoController = videoControllerObj.GetComponent<VideoController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnOyatsuClicked()
    {
        //解答のビデオを流す
        videoController.StartVideo();

        if(oyatsu)
        {
            //正解(おやつカルパスが正解の問題でおやつカルパスを選ぶ)
            quizManager.OyatsuMaru();
        }
        else
        {
            //不正解(違うカルパスが正解の問題でおやつカルパスを選ぶ)
            quizManager.NOyatsuBatsu();
            if (ScoreManager.isCorrect)
            {
                ScoreManager.isCorrect = false;
            }
        }
    }

    public void OnNotOyatsuClicked()
    {
        videoController.StartVideo();

        if (oyatsu)
        {
            //不正解(おやつカルパスが正解の問題でじゃないを選ぶ)
            quizManager.OyatsuBatsu();
            if (ScoreManager.isCorrect)
            {
                ScoreManager.isCorrect = false;
            }
        }
        else
        {
            //正解(違うカルパスが正解の問題でじゃないを選ぶ)
            quizManager.NOyatsuMaru();
        }
    }
}
