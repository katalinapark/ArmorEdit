using UnityEngine;
using System.Collections;
using UnityEngine.UI;

using System.Collections.Generic;

using UnityEngine.SceneManagement;

using System.Linq;


public class timer : MonoBehaviour
{
    float timeRemaining = 45;

    void Start() {

    }

    void Update()
    {
        timeRemaining -= Time.deltaTime;

    }

    void OnGUI()
    {
        if (timeRemaining > 0)
        {
            GUI.Label(new Rect(100, 100, 200, 100), "Time Remaining: "+timeRemaining);

        }
        else
        {
            GUI.Label(new Rect(100, 100, 100, 100), "Time's up");
            SceneManager.LoadScene("Lose", LoadSceneMode.Single);

        }
    }
}