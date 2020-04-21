using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText;  //for text mesh pro

    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        //max = 1000;
        //min = 1;
        //guess = 500;
        NextGuess();

        // at last, because we want 500 at first
        // max = max + 1; // can get to highest number, safe step

    }

    public void OnPressHigher()
    {
        // -1: avoid same number
        min = guess + 1;
        NextGuess();
    }

    public void OnPressLower()
    {
        // -1: avoid same number
        max = guess - 1;
        NextGuess();
    }


    void NextGuess()
    {
        guess = Random.Range(min, max + 1);
        guessText.text = guess.ToString();
    }
}
