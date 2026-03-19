using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private CoinSystem coinSystem;
    
    
    //UI Obj
    [SerializeField] private Text coinText;


    private void Start()
    {
        coinSystem.OnCoinUIChanged += ShowCoinText;
        ShowCoinText(coinSystem.CurrentCoin);
    }

    private void ShowCoinText(int currentCoin)
    {
        coinText.text = currentCoin.ToString();
    }

}
