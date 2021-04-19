using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquippedItemFaceMouse : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        FaceMouse();
    }

    private void FaceMouse()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        Vector2 direction = new Vector2(transform.position.x - mousePosition.x, transform.position.y - mousePosition.y);

        transform.right = -direction;
    }
}
