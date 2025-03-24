using TMPro;
using UnityEngine;
using UnityEngine.UI;

// 금액이 적힌 버튼 클릭시 금액 만큼 현금에서 통장으로 이동
public class Deposit : MonoBehaviour
{
    [Header("Deposit")] public Button tenThousandBtn;
    public Button thirtyThousandBtn;
    public Button fiftyThousandBtn;

    [SerializeField] private TMP_InputField _inputField;

    public void ClickInput(int cash)
    {
        GameManager.instance.DepositCash(cash);
    }
    
    // public void ClickTenThousandBtn()
    // {
    //     GameManager.instance.DepositCash(10000);
    // }
    //
    // public void ClickThirtyThousandBtn()
    // {
    //     GameManager.instance.DepositCash(30000);
    // }
    //
    // public void ClickFiftyThousandBtn()
    // {
    //     GameManager.instance.DepositCash(50000);
    // }

    // 입력한 숫자 값 전달
    public void ClickCustomBtn()
    {
        if (int.TryParse(_inputField.text, out int cash))
        {
            GameManager.instance.DepositCash(cash);
        }
    }
}