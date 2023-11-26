using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectSnowflake : MonoBehaviour
{
    public AudioSource snowflakeFX;

    void OnTriggerEnter(Collider other)
    {
        snowflakeFX.Play();
        CollectableControl.snowflakeCount += 1;
        this.gameObject.SetActive(false);
    }
}
