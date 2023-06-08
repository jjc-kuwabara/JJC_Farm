using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 植物としてのトマトオブジェクトの派生クラス.
public class TomatoPlant : BasePlant
{
    [SerializeField]
    GameObject vegetable;
    [SerializeField]
    int maxVegetableNum;

    override protected void CreateVegetable()
    {
        int vegetableNum = Random.Range(1, maxVegetableNum + 1);

        for (int i = 0; i < vegetableNum; i++)
        {
            GameObject vegetableInstance = Instantiate(vegetable);
            vegetableInstance.transform.SetParent(this.transform);
            vegetableInstance.transform.localPosition = new Vector3(-0.3f + Random.Range(0.0f, 0.6f), -0.3f + Random.Range(0.0f, 0.6f), 0.0f);
        }

    }
}
