using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RankingButton : MonoBehaviour
{
    [SerializeField] GameObject rankPanel;
    [SerializeField] GameObject buttonTextObj;
    Text buttonText;

    [SerializeField] GameObject highScoreDisplayObj;
    HighScoreDisplay highScoreDisplay;

    // Start is called before the first frame update
    void Start()
    {
        rankPanel.SetActive(false);
        buttonText = buttonTextObj.GetComponent<Text>();
        highScoreDisplay = highScoreDisplayObj.GetComponent<HighScoreDisplay>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RankingButtonClicked()
    {
        if (!rankPanel.activeSelf)
        {
            rankPanel.SetActive(true);
            highScoreDisplay.HighScoreLoad();
            buttonText.text = "もどる";
        }
        else
        {
            rankPanel.SetActive(false);           
            buttonText.text = "満点タイム\nランキング";
        }
        
    }
}
