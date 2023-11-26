using UnityEngine;
using UnityEngine.UI;

public class CollectableControl : MonoBehaviour
{
    public static int snowflakeCount;
    public GameObject snowflakeCountDisplay;
    public GameObject snowflakeEndDisplay;

    void Update()
    {
        snowflakeCountDisplay.GetComponent<Text>().text = "" + snowflakeCount;
        snowflakeEndDisplay.GetComponent<Text>().text = "" + snowflakeCount;
    }
}
