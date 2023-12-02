using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    public GameObject[] section;
    public int zPosition = 50;
    public bool isCreatingSection = false;
    public int sectionNumber;

    // Update is called once per frame
    void Update()
    {
        if (isCreatingSection == false)
        {
            isCreatingSection = true;
            StartCoroutine(GenerateSection());
        }
    }

    IEnumerator GenerateSection()
    {
        sectionNumber = Random.Range(0, 15);
        Instantiate(section[sectionNumber], new Vector3(0,0,zPosition), Quaternion.identity);
        zPosition += 50;
        yield return new WaitForSeconds(4);
        isCreatingSection = false;
    }
}
