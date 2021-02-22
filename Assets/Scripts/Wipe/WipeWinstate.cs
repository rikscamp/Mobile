using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WipeWinstate : MonoBehaviour
{
    Wipe rightEye;
    Wipe2 leftEye;

    //Timer Stuff
    public GameObject textDisplay;
    public int secondsLeft;
    public int minsLeft;
    public bool takingAway = false;

    //win state
    public bool win;
    public GameObject mainMenu;
    public GameObject wipeHolder;


    private void Awake()
    {
        rightEye = GetComponent<Wipe>();
        leftEye = GetComponent<Wipe2>();
        textDisplay.GetComponent<TextMeshProUGUI>().text = minsLeft + ":" + secondsLeft;

    }
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        if (takingAway == false && secondsLeft > 0)
        {
            StartCoroutine(TimerTake());
        }



        if (rightEye.rightEyeClean == true && leftEye.leftEyeClean == true)
        {
            Debug.Log("Win");
        }
    }

    IEnumerator TimerTake()
    {
        takingAway = true;
        yield return new WaitForSeconds(1);
        secondsLeft -= 1;
        if (secondsLeft < 10)
        {
            textDisplay.GetComponent<TextMeshProUGUI>().text = minsLeft + ":0" + secondsLeft;
        }
        else
        {
            textDisplay.GetComponent<TextMeshProUGUI>().text = minsLeft + ":" + secondsLeft;
        }



        // reset
        if (secondsLeft == 0 && minsLeft == 0 && win == true)
        {
            Debug.Log("GameOver, you Win!");
            //GameOver functionality works! :D

            mainMenu.SetActive(true);
            wipeHolder.SetActive(false);
            secondsLeft = 5;
            rightEye.wipe = 0;
            leftEye.wipe = 0;
            rightEye.rightEyeClean = false;
            leftEye.leftEyeClean = false;
            rightEye.bigTear.SetActive(true);
            rightEye.smearTear.SetActive(false);
            leftEye.bigTear.SetActive(true);
            leftEye.smearTear.SetActive(false);
            win = false;


        }
        else if (secondsLeft == 0 && minsLeft == 0 && win == false)
        {
            Debug.Log("Loser!");
            mainMenu.SetActive(true);
            wipeHolder.SetActive(false);
            secondsLeft = 5;
            rightEye.wipe = 0;
            leftEye.wipe = 0;
            rightEye.rightEyeClean = false;
            leftEye.leftEyeClean = false;
            rightEye.bigTear.SetActive(true);
            rightEye.smearTear.SetActive(false);
            leftEye.bigTear.SetActive(true);
            leftEye.smearTear.SetActive(false);


            //Todo destroy a life
        }

        takingAway = false;



    }
}
