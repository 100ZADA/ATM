using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[System.Serializable]
public class UserData
{
    public string userName;
    public int bankCash;
    public int cash;

    // 생성자
    public UserData(string userName, int bankCash, int cash)
    {
        this.userName = userName;
        this.bankCash = bankCash;
        this.cash = cash;
        
    }
    
    // 프로퍼지를 이용한 방법
    // [SerializeField] private string userName;
    // public string UserName
    // {
    //     get { return userName; }
    // }
    //
    // [SerializeField] private int bankCash;
    //
    // public int BankCash
    // {
    //     get { return bankCash; }
    // }
    //
    // [SerializeField] private int cash;
    //
    // public int Cash
    // {
    //     get { return cash; }
    // }
}
