using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class check_llegada : MonoBehaviour
{
    public Material material;
    public MeshRenderer mesh;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        mesh.material = material;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
