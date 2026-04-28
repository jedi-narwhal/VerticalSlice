using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inspection : MonoBehaviour
{
    
    public GameObject  detail;
    
    
    public Image _InspectImage;
    
  

    public List<Alien> _allAliens = new List<Alien>(); 
    [SerializeField] private Button _button;
    
    public void ZoomIn(Alien alienpic)
    {
        
        if (detail != null && _InspectImage != null && alienpic != null)
        {
        
            _InspectImage.sprite = alienpic.npc; 
      
            detail.SetActive(true);    
        }
    }

    public void ZoomOut()
    {
        if (detail != null)
        {
            detail.SetActive(false);
        }
    }
    public void SetupButton(Alien alienpic )
    {
                _button.onClick.AddListener(delegate
            {
                ZoomIn(alienpic);
            });
    }

}