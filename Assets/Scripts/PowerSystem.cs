using UnityEngine;
using UnityEngine.UI;

public class PowerSystem : MonoBehaviour
{
    public int power = 0;
    private int amount = 10;
    private Animator anim;
    [SerializeField]
    private Text countTxt;

    public IPowerBar powerBar;

    private void Awake()
    {
        powerBar.SetPower(power);
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        CatEmoji();
        countTxt.text = "" + power;
    }
    public void MinusPower()
    {
        power -= amount;
        if (power < 0)
        {
            power = 0;
        }

        powerBar.SetPower(power);
    }

    public void AddPower()
    {
        power += amount;
        if (power >= 100)
        {
            power = 100;
            GameController.instance.GameEnd();
        }
        powerBar.SetPower(power);
    }

    public void CatEmoji()
    {
        if (power > 0 && power < 20)
        {
            anim.SetBool("sad", true);
        }
        else
        {
            anim.SetBool("sad", false);
        }
        if (power > 20 && power < 50)
        {
            anim.SetBool("normal", true);
        }
        else
        {
            anim.SetBool("normal", false);
        }
        if (power > 50 && power < 70)
        {
            anim.SetBool("good", true);
        }
        else
        {
            anim.SetBool("good", false);
        }
        if (power > 70 && power < 100)
        {
            anim.SetBool("perfect", true);
        }
        else
        {
            anim.SetBool("perfect", false);
        }
    }
}