using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberGuesser : MonoBehaviour {

    [SerializeField] int min;
    [SerializeField] int max;
    [SerializeField] TextMeshProUGUI guessText;
    int guess;

    void Start () {
        StartGame();
	}
	
    void StartGame() {
        NextGuess();
    }

    public void OnPressHigher() {
        min = guess + 1;
        NextGuess();
    }

    public void OnPressLower() {
        max = guess - 1;
        NextGuess();
    }

    void NextGuess() {
        guess = Random.Range(min, max);
        guessText.text = guess.ToString();
    }
}
