using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Body_Passive : MonoBehaviour
{
    // ���������� �������������\\
    public static bool _is_strobing;
    
   
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (!_is_strobing)
            return;
        _is_strobing = false;
    }
}
