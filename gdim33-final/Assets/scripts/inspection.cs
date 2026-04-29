using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class inspection : MonoBehaviour
{
    
    public GameObject  detail;
    
    
    public Image _InspectImage;
    
    public TMP_Text _descriptiontext;
  

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

    public void Description(Alien traits)
    {
        _descriptiontext.text = traits.description;
    }



    public void SetupButton(Alien currentAlien)
    {
               _button.onClick.RemoveAllListeners();
                _button.onClick.AddListener(delegate
                
            {
                ZoomIn(currentAlien);
            });
    }






}