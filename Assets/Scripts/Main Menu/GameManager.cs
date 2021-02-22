using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject textDisplay;
    public GameObject hintDisplay;

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
        
        Debug.Log(randomGame);
    }

    private void Update()
    {
        if (secondsLeft == 5)
        {
            PickNextGame();
            
        }
        if (takingAway == false && secondsLeft > 0)
        {
            StartCoroutine(TimerTake());

        }

        if(secondsLeft == 3)
        {
            GiveHint();
        }

        if (secondsLeft == 0)
        {
            LoadGame();
        }
       

        

    }
    void GiveHint()
    {
        if (randomGame == 1)
        {
            hintDisplay.SetActive(true);
            hintDisplay.GetComponent<TextMeshProUGUI>().text = "Punch";
            
        }
        if (randomGame == 2)
        {
            hintDisplay.SetActive(true);
            hintDisplay.GetComponent<TextMeshProUGUI>().text = "Console";
        }
    }

    void LoadGame()
    {
        if (randomGame == 1)
        {
            Debug.Log("woo");

            mainMenu.SetActive(false);
            hintDisplay.SetActive(false);
            secondsLeft = 5;
            punchLevel.SetActive(true);
        }
        if (randomGame == 2)
        {
            Debug.Log("too");

            mainMenu.SetActive(false);
            hintDisplay.SetActive(false);
            secondsLeft = 5;
            wipeLevel.SetActive(true);

        }
    }

    void PickNextGame()
    {
        randomGame = Random.Range(1, 3);
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
