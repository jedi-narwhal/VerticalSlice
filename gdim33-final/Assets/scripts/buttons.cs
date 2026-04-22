using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class buttons : MonoBehaviour
{
    public static int _score;
    public TMP_Text _scoretext;
    void Start()
    {
        _score= 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Onaccept()
    {
        _score++;
        _scoretext.text= "score: " + _score.ToString();
      
    }

    public void Ondeny()
    {
        _score--;
        _scoretext.text= "score: " + _score.ToString();
    }


}
