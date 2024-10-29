using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class DamageIndicator : MonoBehaviour
{
    public Image image;
    public float flashSpeed;

    private Coroutine coroutine;

    void Start() 
    {
        CharacterManager.Instance.Player.condition.onTakeDamage += Flash;
    }
    
    public void Flash()
    {
        if (coroutine != null)
        {
            StopCoroutine(coroutine);
        }
        image.enabled = true;
        image.color = new Color(1f, 100 / 255f, 100 / 255f);
        coroutine = StartCoroutine(FadeAway());
    }

    private IEnumerator FadeAway()
    {
        float startAlpha = 0.3f;
        float a = startAlpha;

        while (a > 0)
        {
            a -= (startAlpha / flashSpeed) * Time.deltaTime;
            image.color = new Color(1f, 100 / 255f, 100 / 255f, a);

            yield return null;      // 반환값을 정해줘야 코루틴을 정상적으로 사용할 수 있음, 적절한 반환값이 없다면 null 반환해주면 됨 
        }

        image.enabled = false;
    }
}
