using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject arrowPrefab;
    float span = 1.0f;
    float delta = 0;
    public GameObject hpGauge;
    public GameObject Catfood;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GenerateArrow", 0, 1);
        InvokeRepeating("Generatecatfood", 5, 5);
    }

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        if (delta > span)
        {
            delta = 0;
            int px = Random.Range(-6, 7);
            Instantiate(arrowPrefab, new Vector3(px, 7, 0), Quaternion.identity);
        }
    }
    public void DecreaseHp()
    {
        hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
    }
    void GenerateArrow()
    {
        float px = Random.Range(-6.0f, 7.0f);
        Instantiate(arrowPrefab, new Vector3(px, 7, 0), Quaternion.identity);
    }
    void GenerateCatfood()
    {
        float px = Random.Range(-6.0f, 7.0f);
        Instantiate(Catfood, new Vector3(px, 7, 0), Quaternion.identity);
    }
}
