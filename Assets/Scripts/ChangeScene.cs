using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    string sceneName; //�ǂݍ��ރV�[����

    public static List<int> numList =
        new List<int>() {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32}; //���ԍ��̓��������X�g
    public static List<int> useList = new List<int>(); //���łɑI�΂ꂽ���ԍ��̃��X�g
    int randomNum;
    int choiceNum;

    // Start is called before the first frame update
    void Start()
    {
        //numList���烉���_���łP�I��
        randomNum = numList[Random.Range(0, numList.Count)];

        //�I�񂾖��ԍ���useList�ɒǉ�
        useList.Add(randomNum);

        //�I�񂾖��ԍ��̃��X�g�ԍ����擾
        choiceNum = numList.IndexOf(randomNum);

        //�������X�g�ԍ���numList����폜
        numList.RemoveAt(choiceNum);

        if (useList.Count <= 10)
        {
            sceneName = "Question" + randomNum.ToString();
        }
        else
        {
            sceneName = "Result";
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log(numList.Count);
        }
    }

    //�V�[����ǂݍ���
    public void Load()
    {
        SceneManager.LoadScene(sceneName);
    }

    
}
