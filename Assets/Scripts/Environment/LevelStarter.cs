using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStarter : MonoBehaviour
{
    public GameObject countDownThree;
    public GameObject countDownTwo;
    public GameObject countDownOne;
    public GameObject countDownGo;
    public GameObject ready;
    public AudioSource readyFX;
    public AudioSource goFX;

    void Start()
    {
        StartCoroutine(CountSequence());
    }

    IEnumerator CountSequence()
    {
        yield return new WaitForSeconds(1.5f);
        countDownThree.SetActive(true);
        yield return new WaitForSeconds(1);
        countDownTwo.SetActive(true);
        yield return new WaitForSeconds(1);
        countDownOne.SetActive(true);
        yield return new WaitForSeconds(1);
        ready.SetActive(true);
        readyFX.Play();
        yield return new WaitForSeconds(1);
        countDownGo.SetActive(true);
        goFX.Play();
        PlayerMove.canMove = true;
    }
}
