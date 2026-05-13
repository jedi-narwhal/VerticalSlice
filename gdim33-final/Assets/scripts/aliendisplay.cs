using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using Unity.VisualScripting;
using TMPro;

public class aliendisplay : MonoBehaviour
{
    public Image alienImage;
    public List<Alien> _allAliens = new List<Alien>(); 
    public inspection detailedViewer;
     public buttons alienbutton;
    public int _currentIndex;
    public gamemanager _gamemanager;


   public static aliendisplay Instance { get; private set; }
    public Alien currentAlien;
    private void Awake() {
        _currentIndex=-1;
        if (Instance != null && Instance != this)
        {
            Destroy(this);
            return;

        }
        Instance = this;
    }




    void Start()    
    {
        UpdateAlienUI();
    }

    public Alien NextAlien()
    {
        if (_allAliens.Count == 0)
        {
            
            return null;
        }

        _currentIndex++;
        
        if (_currentIndex >= _allAliens.Count) 
        {
            _gamemanager.FinalScoreScreen();
            return null;

        }
        
        UpdateAlienUI();
        return currentAlien;
    }

    private void UpdateAlienUI()
    {
        
        if (_allAliens.Count > 0)
        {
             currentAlien = _allAliens[_currentIndex];
            alienImage.sprite = _allAliens[_currentIndex].npc;
            
            detailedViewer.SetupButton(currentAlien);
                
  
            
        }
    }
}

