using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiceManager : MonoBehaviour
{
    public bool oyatsu; //���̉摜������J���p�X�Ȃ�true
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
        //�𓚂̃r�f�I�𗬂�
        videoController.StartVideo();

        if(oyatsu)
        {
            //����(����J���p�X�������̖��ł���J���p�X��I��)
            quizManager.OyatsuMaru();
        }
        else
        {
            //�s����(�Ⴄ�J���p�X�������̖��ł���J���p�X��I��)
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
            //�s����(����J���p�X�������̖��ł���Ȃ���I��)
            quizManager.OyatsuBatsu();
            if (ScoreManager.isCorrect)
            {
                ScoreManager.isCorrect = false;
            }
        }
        else
        {
            //����(�Ⴄ�J���p�X�������̖��ł���Ȃ���I��)
            quizManager.NOyatsuMaru();
        }
    }
}
