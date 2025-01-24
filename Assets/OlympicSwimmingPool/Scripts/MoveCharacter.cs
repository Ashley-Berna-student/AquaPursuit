using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
    // Start is called before the first frame update
    public void Move()
    {
        DontDestroyOnLoad(gameObject);
        print(gameObject.scene.name);
    }
}
