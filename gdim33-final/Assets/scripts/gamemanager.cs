using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Video;
using System;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class gamemanager : MonoBehaviour
{

   public static int _score;
    public TMP_Text _scoretext;
    public aliendisplay aliendisplay;
    public GameObject panel;
  //final text score needs to be implemetned and hooked up in inspector



    // Start is called before the first frame update
public void Start()
    {
        _score= 0;
        _scoretext.text= "score:0";
         panel.SetActive(false);
        
    }

public void CheckAccuracy (bool playeraccept)
    {
        
    Alien currentAlien = aliendisplay.Instance.currentAlien;
        if (playeraccept == currentAlien.is_admitted)
        {
            _score++;
        }
        else
        {
            _score--;
        }
        _scoretext.text = "Score: " + _score.ToString();
    }

public void FinalScoreScreen()
    {
        panel.SetActive(true);
        UpdateScoreText();
    }
public void UpdateScoreText()
    {
        if (_score >= 30)
        {
            _scoretext.text= "You got promoted";
        }
        else
        {
            _scoretext.text= " You are fired";
        }
    }

   /* public void SetupButton(bool playeraccept,Alien currentAlien)
    {
               acceptbutton.onClick.RemoveAllListeners();
                denybutton.onClick.AddListener(delegate
                
            {
                ZoomIn(currentAlien);
            });
    }
*/
}
