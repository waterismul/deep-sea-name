using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ButtonSystem : MonoBehaviour
{
    [SerializeField] private Image[] iconImages;
    private int currentIndex;
    
    private void Start()
    {
        currentIndex = -1;
        for (int i = 0; i < iconImages.Length; i++)
        {
            iconImages[i].DOFade(0.5f,0f);
        }
        
      
    }
    

     //버튼 3개로 조작시
    private void ClickA()//선택
    {
        int prevIndex = currentIndex;
        
        currentIndex++;
        if(currentIndex >= iconImages.Length)
            currentIndex = 0;
        
        if(prevIndex >=0)
            iconImages[prevIndex].DOFade(0.5f,0f);
           
        iconImages[currentIndex].DOFade(1f, 0f);
        
    }
    
    private void ClickB()//확인
    {
        
    }
    
    private void ClickC()//취소
    {
        currentIndex = -1;
        for (int i = 0; i < iconImages.Length; i++)
        {
            iconImages[i].DOFade(0.5f,0f);
        }
    }
    
}
