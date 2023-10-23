
using UnityEngine;

public class BlueScore : MonoBehaviour
{
    public float cashV;
    public float currentCashV;

    void Update()
    {
        transform.RotateAround(this.transform.position, Vector3.up , 100 * Time.deltaTime );
    }


    void OnTriggerEnter()
    {
        cashV = PlayerPrefs.GetFloat("cash", cashV);
        currentCashV = PlayerPrefs.GetFloat("currentCash", currentCashV);

        cashV += 4;
        currentCashV += 4;

        PlayerPrefs.SetFloat("cash", cashV);
        PlayerPrefs.SetFloat("currentCash", currentCashV);

        gameObject.SetActive(false);
    }
}


