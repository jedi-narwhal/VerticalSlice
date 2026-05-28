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
  
    public Image alien;

    public List<Alien> _allAliens = new List<Alien>(); 
    [SerializeField] private Button _button;

    public Material _material;


    
    public void ZoomIn(Alien alienpic)
    {
        _InspectImage.sprite = alienpic.body_part; 
        detail.SetActive(true); 
        
        
    }

    public void ZoomOut()
    {
  
        detail.SetActive(false);
        
    }

    public void Description(Alien traits)
    {
        _descriptiontext.text = traits.description;
    }
    public void Changematerial()
    {
        alien.material= _material;
    }


    public void SetupButton(Alien currentAlien)
    {
               _button.onClick.RemoveAllListeners();
                _button.onClick.AddListener(delegate
                
            {
                ZoomIn(currentAlien);
                Changematerial();
            });
    }






}