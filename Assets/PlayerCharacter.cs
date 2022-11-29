using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    private int health;
    // Start is called before the first frame update
    void Start()
    {
        this.health = 5;
    }

    // Update is called once per frame
    public void Hurt(int damage)
    {
        this.health -= damage;
        Debug.Log($"Health: {this.health}");
    }
}
