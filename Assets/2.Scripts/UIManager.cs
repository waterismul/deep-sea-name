using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    [SerializeField] private CoinSystem coinSystem;
    
    //UI Obj
    [SerializeField] private Text coinText;

    [SerializeField] private Toggle[] menuToggles;
    [SerializeField] private GameObject[] menuPanels;


    private void Start()
    {
        coinSystem.OnCoinUIChanged += ShowCoinText;
        ShowCoinText(coinSystem.CurrentCoin);
     
        SetToggles();
    }


    private void SetToggles()
    {
        for (int i = 0; i < menuToggles.Length; i++)
        {
            int index = i; // 클로저 문제 방지

            menuToggles[i].onValueChanged.AddListener((isOn) =>
            {
                if (isOn)
                    OnToggleSelected(index);
            });
        }

        // 초기 상태
        OnToggleSelected(99);
    }
    
    private void OnToggleSelected(int index)
    {
        for (int i = 0; i < menuPanels.Length; i++)
        {
            menuPanels[i].SetActive(i == index);
        }
    }


    public void ClosePanel()
    {
        for (int i = 0; i < menuPanels.Length; i++)
        {
            menuPanels[i].SetActive(false);
            menuToggles[i].isOn = false;
        }
    }
    

    private void ShowCoinText(int currentCoin)
    {
        coinText.text = currentCoin.ToString();
    }

   

}
