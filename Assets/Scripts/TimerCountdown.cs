using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerCountdown : MonoBehaviour
{
    public GameObject textDisplay;

    //Levels
    

    public int secondsLeft;
    public int minsLeft;
    public bool takingAway = false;


    private void Start()
    {
        textDisplay.GetComponent<TextMeshProUGUI>().text = minsLeft + ":" + secondsLeft;
    }

    private void Update()
    {
        if (takingAway == false && secondsLeft > 0)
        {
            StartCoroutine(TimerTake());

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

        if (secondsLeft == 0 && minsLeft == 0)
        {
            //Debug.Log("GameOver");
            //GameOver functionality works! :D

        }

        takingAway = false;



    }
}
