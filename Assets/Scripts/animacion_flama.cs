using UnityEngine.InputSystem;
using UnityEngine;

public class animacion_flama : MonoBehaviour
{
    public ParticleSystem[] efectos;
    // Start is called before the first frame update
    void Start()
    {
        foreach(ParticleSystem x in efectos)
        {
            x.Stop();
            x.Clear();
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
