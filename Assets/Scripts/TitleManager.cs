using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleManager : MonoBehaviour
{
    private void Awake()
    {
        //Še’l‚ğ‚ğ‰Šú‰»
        ChangeScene.numList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32 };

        ChangeScene.useList.Clear();

        ScoreManager.score = 0;

        ScoreManager.isCorrect = true;

        ScoreManager.time = 0;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
