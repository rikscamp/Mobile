using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Punch : MonoBehaviour
{
    Controls controls;

   

    //Tumblin Animator
    public Animator anim;
    //Wardrobe Animator
    public Animator war;

    public GameObject sock;

    public int hits = 0;


    //Timer Stuff
    public GameObject textDisplay;
    public int secondsLeft;
    public int minsLeft;
    public bool takingAway = false;

    //win state
    public bool win;
    public GameObject mainMenu;
    public GameObject punchHolder;

    private void Awake()
    {
        controls = new Controls();

        controls.Punch.Tap.performed += ctx => Pawnch();



    }


    // Start is called before the first frame update
    void Start()
    {
        textDisplay.GetComponent<TextMeshProUGUI>().text = minsLeft + ":" + secondsLeft;
    }

    // Update is called once per frame
    void Update()
    {
        if (takingAway == false && secondsLeft > 0)
        {
            StartCoroutine(TimerTake());
        }
    }

    void Pawnch()
    {
        hits = hits + 1;
        anim.SetTrigger("isPunch");
        switch (hits)
        {
            
            case 20:
                war.SetTrigger("isPunched2");
                Debug.Log("Win");
                sock.SetActive(false);
                anim.SetBool("isWin", true);
                //Todo 
                win = true;
                break;
            case 19:
                war.SetTrigger("isPunched");
                Debug.Log(hits);
                break;
            case 18:
                war.SetTrigger("isPunched2");
                Debug.Log(hits);
                break;
            case 17:
                war.SetTrigger("isPunched");
                Debug.Log(hits);
                break;
            case 16:
                war.SetTrigger("isPunched2");
                Debug.Log(hits);
                break;
            case 15:
                war.SetTrigger("isPunched");
                Debug.Log(hits);
                break;
            case 14:
                war.SetTrigger("isPunched2");
                Debug.Log(hits);
                break;
            case 13:
                war.SetTrigger("isPunched");
                Debug.Log(hits);
                break;
            case 12:
                war.SetTrigger("isPunched2");
                Debug.Log(hits);
                break;
            case 11:
                war.SetTrigger("isPunched");
                Debug.Log(hits);
                break;
            case 10:
                war.SetTrigger("isPunched2");
                Debug.Log(hits);
                break;
            case 9:
                war.SetTrigger("isPunched");
                Debug.Log(hits);
                break;
            case 8:
                war.SetTrigger("isPunched2");
                Debug.Log(hits);
                break;
            case 7:
                war.SetTrigger("isPunched");
                Debug.Log(hits);
                break;
            case 6:
                war.SetTrigger("isPunched2");
                Debug.Log(hits);
                break;
            case 5:
                war.SetTrigger("isPunched");
                Debug.Log(hits);
                break;
            case 4:
                war.SetTrigger("isPunched2");
                Debug.Log(hits);
                break;
            case 3:
                war.SetTrigger("isPunched");
                Debug.Log(hits);
                break;
            case 2:
                war.SetTrigger("isPunched2");
                Debug.Log(hits);
                break;
            case 1:
                war.SetTrigger("isPunched");
                Debug.Log(hits);
                break;
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
            punchHolder.SetActive(false);
            secondsLeft = 5;
            hits = 0;
            win = false;
            

        }
        else if (secondsLeft == 0 && minsLeft == 0 && win == false)
        {
            Debug.Log("Loser!");
            mainMenu.SetActive(true);
            punchHolder.SetActive(false);
            secondsLeft = 5;
            hits = 0;
            

            //Todo destroy a life
        }

        takingAway = false;



    }


    private void OnEnable()
    {
        controls.Punch.Enable();
    }

    private void OnDisable()
    {
        controls.Punch.Disable();
    }
}
