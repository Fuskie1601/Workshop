
using UnityEngine;

public class Orrient_Gun : MonoBehaviour {
    Vector3 mouse_pos;
    public Transform target;
    Vector3 object_pos;
    float angle;
 
    void Update()
    {
        // Get the cursor`s location
        mouse_pos = Input.mousePosition;
        // Because cursor`s location is a Vector 3D so we have to declare z axis
        // But it`s does not mean any thing
        mouse_pos.z = 5.23f;
        // Get the player`s location
        // The under line just the code I copy on the internet
        // Actually we can just use target.position is alright
        object_pos = Camera.main.WorldToScreenPoint(target.position);
        //That Vector 2D to calculate angle which control player`s z rotation
        mouse_pos.x = mouse_pos.x - object_pos.x;
        mouse_pos.y = mouse_pos.y - object_pos.y;
        angle = Mathf.Atan2(mouse_pos.y, mouse_pos.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }
}
