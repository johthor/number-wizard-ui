using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour
{

    private int minNumber;
    private int maxNumber;

    private int guess;
    private int guessesRemaining;

    public Text guessText;

    // Use this for initialization
    void Start()
    {
        StartGame();	
    }

    public void GuessHigher()
    {
        minNumber = guess;
        MakeAGuess();
    }

    public void GuessLower()
    {
        maxNumber = guess;
        MakeAGuess();

    }

    private	void StartGame()
    {
        minNumber = 1;
        maxNumber = 1000;

        guessesRemaining = 10;

        MakeAGuess();
    }

    private void MakeAGuess()
    {
        guess =	Random.Range(minNumber, maxNumber + 1);
        guessText.text = guess.ToString();
        guessesRemaining -= 1;

        if (guessesRemaining <= 0)
        {
            SceneManager.LoadScene("Win");
        }
    }
}
