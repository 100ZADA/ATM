using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 1번째 버튼을 입출금 기능 버튼을 누르면 ATM패널이 사라지게 만들고 해당 패널 소환
public class PopUpBank : MonoBehaviour
{
    public GameObject atmPanel;
    public Button[] backBtn;

    [Header("Deposit")]
    public Button depositBtn;
    public GameObject depositPanel;

    [Header("Withdraw")]
    public Button withdrawBtn;
    public GameObject withdrawPanel;

    [Header("PopUpError")]
    public GameObject popUpError;
    
    public GameManager gameManager;
    
    // 입금 버튼
    public void OnClickDeposit()
    {
        ShowPanel(depositPanel);
    }

    // 출금 버튼
    public void OnClickWithdraw()
    {
        ShowPanel(withdrawPanel);
    }

    // 뒤로가기 버튼
    public void OnClickBack()
    {
        HidePanel(depositPanel);
        HidePanel(withdrawPanel);
    }

    private void ShowPanel(GameObject panel)
    {
        if (panel != null)
        {
            atmPanel.SetActive(false);
            panel.SetActive(true);
        }
    }

    private void HidePanel(GameObject panel)
    {
        if (panel != null)
        {
            atmPanel.SetActive(true);
            panel.SetActive(false);
        }
    }
    
    public void ClosePopUp()
    {
        popUpError.SetActive(false);
    }
}