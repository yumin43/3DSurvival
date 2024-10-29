using UnityEngine;
using UnityEngine.UI;

public class Condition : MonoBehaviour
{
    public float curValue;      // 계속 바뀌는 값
    public float startValue;
    public float maxValue;
    public float passiveValue;
    public Image uiBar;

    // Start is called before the first frame update
    void Start()
    {
        curValue = startValue;
    }

    // Update is called once per frame
    void Update()
    {
        // UI 업데이트
        uiBar.fillAmount = GetPercentage();
    }

    float GetPercentage()
    {
        return curValue / maxValue;
    }

    public void Add(float value)
    {
        curValue = Mathf.Min(curValue + value, maxValue);        // 두 인자 중 더 작은 값 리턴
    }

    public void Subtract(float value)
    {
        curValue = Mathf.Max(curValue - value, 0);          // 두 인자 중 더 큰 값 리턴
    }
}
