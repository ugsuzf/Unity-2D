using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NumberWizard : MonoBehaviour
{
    public Text guessText;
    public int max;
    public int min;
    public int guess;
    // Start is called before the first frame update
    void Start()
    {
        guess = (max + min) / 2;
        guessText.text = guess.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void higherPressed()
    {
        min = guess;
        NextGuess();
        guessText.text = guess.ToString();

    }

    public void lowerPressed()
    {
        max = guess;
        NextGuess();
    }


    void NextGuess()
    {
        guess = (max + min) / 2;
        guessText.text = guess.ToString();

    }
}
