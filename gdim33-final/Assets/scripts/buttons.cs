using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Unity.VisualScripting;


public class buttons : MonoBehaviour
{
    public static int _score;
    public TMP_Text _scoretext;
    public aliendisplay aliendisplay;


    public gamemanager _gamemanager;
      
    void Start()
    {
        _score= 0;
        _scoretext.text= "score:0";
    }

    // Update is called once per frame
 
public void UpdateAlienUI()
    {
        aliendisplay.NextAlien();
    }




}
