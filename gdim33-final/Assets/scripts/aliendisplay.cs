using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using Unity.VisualScripting;
using TMPro;

public class aliendisplay : MonoBehaviour
{
    public Image alienImage;

    public TMP_Text alienName;

    public List<Alien> _allAliens = new List<Alien>(); 
    
    private int _currentIndex=0;


    void Awake()
    {
        _currentIndex=0;
    }

    void Start()    
    {
        UpdateAlienUI();
    }

    public void NextAlien()
    {
        if (_allAliens.Count == 0)
        {
            
            return;
        }

        _currentIndex++;
        
        if (_currentIndex >= _allAliens.Count) 
        {
            _currentIndex = 0; 
        }
        
        UpdateAlienUI();
    }

    private void UpdateAlienUI()
    {
        if (_allAliens.Count > 0)
        {
    
            alienImage.sprite = _allAliens[_currentIndex].npc;
            alienName.text= _allAliens[_currentIndex].npc_name;
        }
    }
}

