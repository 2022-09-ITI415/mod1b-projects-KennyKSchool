using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HighScore : MonoBehaviour{
    static public int    score = 1000;



    void Awake() {                                                           // a

        // If the PlayerPrefs HighScore already exists, read it

        if (PlayerPrefs.HasKey("HighScore")) {                               // b

            score = PlayerPrefs.GetInt("HighScore");

        }

        // Assign the high score to HighScore

        PlayerPrefs.SetInt("HighScore", score);                              // c

    }



    void Update () {

        TextMeshProUGUI gt = this.GetComponent<TextMeshProUGUI>();

        gt.text = "High Score: "+score;

        // Update the PlayerPrefs HighScore if necessary

        if (score > PlayerPrefs.GetInt("HighScore")) {                       // d

            PlayerPrefs.SetInt("HighScore", score);

        }

    }

}
