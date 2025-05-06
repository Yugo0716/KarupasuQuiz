using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class QuizManager : MonoBehaviour
{
    public GameObject oyatsuButtonObj;
    public GameObject nOyatsuButtonObj;
    public GameObject nextButtonObj;

    public Button oyatsuButton;
    public Button nOyatsuButton;

    public GameObject oyatsuMaruImage;
    public GameObject oyatsuBatsuImage;
    public GameObject nOyatsuMaruImage;
    public GameObject nOyatsuBatsuImage;

    public GameObject scoreManagerObj;
    public ScoreManager scoreManager;

    public float waitTime; //�R���[�`���̑҂�����

    public AudioClip maruSound;
    public AudioClip batsuSound;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        scoreManager = scoreManagerObj.GetComponent<ScoreManager>();
        audioSource = GetComponent<AudioSource>();

        //next�{�^���ƃ}���ƃo�c�̉摜���\��
        nextButtonObj.SetActive(false);
        oyatsuMaruImage.SetActive(false);
        oyatsuBatsuImage.SetActive(false);
        nOyatsuMaruImage.SetActive(false);
        nOyatsuBatsuImage.SetActive(false);

        scoreManager.isTime = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //����(����J���p�X�������̖��ł���J���p�X��I��)
    public void OyatsuMaru()
    {
        scoreManager.isTime = false;
        scoreManager.ScorePlus();
        StartCoroutine("OyatsuMaruCor"); //�����̉摜��������܂őҋ@
    }

    //�s����(����J���p�X�������̖��ł���Ȃ���I��)
    public void OyatsuBatsu()
    {
        scoreManager.isTime = false;
        StartCoroutine("OyatsuBatsuCor");
    }

    //����(�Ⴄ�J���p�X�������̖��ł���Ȃ���I��)
    public void NOyatsuMaru()
    {
        scoreManager.isTime = false;
        scoreManager.ScorePlus();
        StartCoroutine("NOyatsuMaruCor");
    }

    //�s����(�Ⴄ�J���p�X�������̖��ł���J���p�X��I��)
    public void NOyatsuBatsu()
    {
        scoreManager.isTime = false;
        StartCoroutine("NOyatsuBatsuCor");
    }

    IEnumerator OyatsuMaruCor()
    {
        oyatsuButton.interactable = false;
        nOyatsuButtonObj.SetActive(false);

        yield return new WaitForSeconds(waitTime);
        
        oyatsuMaruImage.SetActive(true);
        nextButtonObj.SetActive(true);
        audioSource.PlayOneShot(maruSound);
    }

    IEnumerator OyatsuBatsuCor()
    {
        nOyatsuButton.interactable = false;
        oyatsuButtonObj.SetActive(false);

        yield return new WaitForSeconds(waitTime);
        
        nOyatsuBatsuImage.SetActive(true);
        nextButtonObj.SetActive(true);
        audioSource.PlayOneShot(batsuSound);
    }

    IEnumerator NOyatsuMaruCor()
    {
        nOyatsuButton.interactable = false;
        oyatsuButtonObj.SetActive(false);

        yield return new WaitForSeconds(waitTime);
        
        nOyatsuMaruImage.SetActive(true);
        nextButtonObj.SetActive(true);
        audioSource.PlayOneShot(maruSound);
    }

    IEnumerator NOyatsuBatsuCor()
    {
        oyatsuButton.interactable = false;
        nOyatsuButtonObj.SetActive(false);

        yield return new WaitForSeconds(waitTime);
        
        oyatsuBatsuImage.SetActive(true);
        nextButtonObj.SetActive(true);
        audioSource.PlayOneShot(batsuSound);
    }
}
