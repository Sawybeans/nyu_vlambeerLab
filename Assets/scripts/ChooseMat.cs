using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChooseMat : MonoBehaviour
{

    public Material woodMat;
    public Material carpMat;
    public Material kitchMat;

    // Start is called before the first frame update
    void Start()
    {
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        Material oldMaterial = meshRenderer.material;
        float choose = Random.Range(0f, 1.0f);

        if (choose < 0.60f)
        {
            meshRenderer.material = woodMat;
        }

        else if (choose >= 0.60f && choose <= 0.90f)
        {
            meshRenderer.material = carpMat;
        }

        else if (choose > 0.90f)
        {
            meshRenderer.material = kitchMat;
        }
    }

    // Update is called once per frame
    void Update()
    {


    }
}
