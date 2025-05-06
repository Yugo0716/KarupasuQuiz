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

        if (ScoreManager.score <= 0) comment = "�t�ɂ�����!!!!";
        else if (ScoreManager.score <= 3) comment = "�����ƃJ���p�X�ɏڂ����Ȃ낤";
        else if (ScoreManager.score <= 6) comment = "�܂��܂�����";
        else if (ScoreManager.score <= 9) comment = "�v���̂���J���p�X�Ӓ�m";
        else if (ScoreManager.score <= 10) comment = "���͂�J���p�X�𓝂ׂ鑶��";

        scoreText.text = "10�⒆�@" + ScoreManager.score + "�@�␳��!\n\n" + comment;

        if(ScoreManager.isCorrect)
        {
            timeObject.SetActive(true);
            timeText.text = "�N���A�^�C���F" + ScoreManager.time.ToString("N2") + "�b�I�I";
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
