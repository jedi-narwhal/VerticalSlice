using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetailZoomController : MonoBehaviour
{
    
    public GameObject  detail;
    
    
    public Image _InspectImage;

    
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
}