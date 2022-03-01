using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private UI_Inventory uiInventory;
    private Rigidbody2D body;
    private float horizontalInput;
    private Inventory inventory;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();

        inventory = new Inventory();
        uiInventory.SetInventory(inventory);
    }
    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        if (horizontalInput > 0.1f)
        {
            body.transform.localScale = Vector2.one;
        }
        else if (horizontalInput < 0.1f)
        {
            body.transform.localScale = new Vector2(-1, 1);
        }

        body.velocity = new Vector2(horizontalInput * speed, 0);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        ItemWorld itemWorld = collider.GetComponent<ItemWorld>();
        if (itemWorld != null)
        {
            inventory.AddItem(itemWorld.GetItem());
            itemWorld.DestroySelf();
        }
    }
}