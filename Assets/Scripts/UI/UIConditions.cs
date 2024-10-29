using UnityEngine;

public class UIConditions : MonoBehaviour
{
    public Condition health;
    public Condition hunger;
    public Condition stamina;

    // Start is called before the first frame update
    void Start()
    {
        CharacterManager.Instance.Player.condition.uiConditions = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
