using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static int score = 0;
    public static bool isCorrect = false;

    public static float time;
    public bool isTime = false;

    // Start is called before the first frame update
    void Start()
    {
        if(SceneManager.GetActiveScene().name == "Result")
        {
            isTime = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isTime)
        {
            time += Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(time);
        }
    }

    public void ScorePlus()
    {
        score++;
    }
}
