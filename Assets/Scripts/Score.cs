using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI ScoreTxt;
    public static int ScoreValue;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        ScoreTxt.text = "Score: " + ScoreValue;
    }
}
