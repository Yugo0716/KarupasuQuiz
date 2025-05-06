using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    string sceneName; //読み込むシーン名

    public static List<int> numList =
        new List<int>() {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32}; //問題番号の入ったリスト
    public static List<int> useList = new List<int>(); //すでに選ばれた問題番号のリスト
    int randomNum;
    int choiceNum;

    // Start is called before the first frame update
    void Start()
    {
        //numListからランダムで１つ選ぶ
        randomNum = numList[Random.Range(0, numList.Count)];

        //選んだ問題番号をuseListに追加
        useList.Add(randomNum);

        //選んだ問題番号のリスト番号を取得
        choiceNum = numList.IndexOf(randomNum);

        //同じリスト番号をnumListから削除
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

    //シーンを読み込む
    public void Load()
    {
        SceneManager.LoadScene(sceneName);
    }

    
}
