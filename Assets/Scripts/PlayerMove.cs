using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody pj;
    public Vector2 aceleracion;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var teclado = Keyboard.current;



        if (teclado.spaceKey.isPressed)
        {
            pj.AddForce(0, aceleracion.y, 0);
        }
        if (teclado.aKey.isPressed)
        {
            pj.AddForce(-aceleracion.x, 0, 0);
        }
        if (teclado.dKey.isPressed)
        {
            pj.AddForce(aceleracion.x,0, 0);
        }
    }
}
