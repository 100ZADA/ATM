using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Money : MonoBehaviour
{
    public TextMeshProUGUI bankCashPointText;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI cashPointText;

    void Start()
    {
        Refresh(GameManager.instance.userData);
    }

    public void Refresh(UserData userData)
    {
        bankCashPointText.text = userData.bankCash.ToString("N0");
        cashPointText.text = userData.cash.ToString("N0");
        nameText.text = userData.userName;
    }
}