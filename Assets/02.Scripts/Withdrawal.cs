using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Withdrawal : MonoBehaviour
{
    [Header("Withdrawal")] public Button tenThousandBtn;
    public Button thirtyThousandBtn;
    public Button fiftyThousandBtn;

    [SerializeField] private TMP_InputField _inputField;

    public void ClickInput(int cash)
    {
        GameManager.instance.WithdrawCash(cash);
    }

    // public void ClickTenThousandBtn()
    // {
    //     GameManager.instance.WithdrawCash(10000);
    // }
    //
    // public void ClickThirtyThousandBtn()
    // {
    //     GameManager.instance.WithdrawCash(30000);
    // }
    //
    // public void ClickFiftyThousandBtn()
    // {
    //     GameManager.instance.WithdrawCash(50000);
    // }

    public void ClickCustomBtn()
    {
        if (int.TryParse(_inputField.text, out int cash))
        {
            GameManager.instance.WithdrawCash(cash);
        }
    }
}