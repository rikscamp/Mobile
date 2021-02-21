using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject textDisplay;

    //Levels
    public GameObject punchLevel;
    public GameObject wipeLevel;
    public GameObject mainMenu;

    private int randomGame;
    public int secondsLeft;
   
    public bool takingAway = false;

    private void Awake()
    {
      

    }


    private void Start()
    {
        textDisplay.GetComponent<TextMeshProUGUI>().text =":0" + secondsLeft;
        randomGame = Random.Range(1, 3);
        Debug.Log(randomGame);
    }

    private void Update()
    {
        if (takingAway == false && secondsLeft > 0)
        {
            StartCoroutine(TimerTake());

        }

       

        if (secondsLeft == 0 && randomGame == 1)
        {
            Debug.Log("woo");
            
            mainMenu.SetActive(false);
            secondsLeft = 5;
            punchLevel.SetActive(true);
        }
        if (secondsLeft == 0 && randomGame == 2)
        {
            Debug.Log("too");

            mainMenu.SetActive(false);
            secondsLeft = 5;
            wipeLevel.SetActive(true);
        }

    }

    IEnumerator TimerTake()
    {
        takingAway = true;
        yield return new WaitForSeconds(1);
        secondsLeft -= 1;
        if (secondsLeft < 10)
        {
            textDisplay.GetComponent<TextMeshProUGUI>().text =":0" + secondsLeft;
        }
        else
        {
            textDisplay.GetComponent<TextMeshProUGUI>().text =":" + secondsLeft;
        }

        if (secondsLeft == 0 )
        {
            //Debug.Log("GameOver");
            //GameOver functionality works! :D

        }

        takingAway = false;



    }
}
