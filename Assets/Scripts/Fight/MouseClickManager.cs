using UnityEngine;

public class MouseClickManager : MonoBehaviour
{
    public RaycastHit hit;
    //public Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    public Ray Ray(){
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        return ray;
    }
}
