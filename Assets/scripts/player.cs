using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float jumpforce = 10f;

    public Rigidbody2D rb;
    
    public string currentColor;
    private int index;
    public GameObject gameover;

    public SpriteRenderer sr;

    public Color colorCyan;
    public Color colorYellow;
    public Color colorPink;
    public Color colorPurple;

    private void Start()
    {
        SetRandomColor();
    }
    void Update()
    {
        if(Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
        {
            rb.velocity = new Vector2(0, jumpforce);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Colorchanger")
        { 
            SetRandomColor();
            Destroy(collision.gameObject);
        }
        else if (collision.tag != currentColor)
        {
            gameover.SetActive(true);
        }
        
    }

    void SetRandomColor()
    {
        index = Random.Range(0, 4);
        switch (index) {
            case 0:
                currentColor = "Cyan";
                sr.color = colorCyan;
                break;
            case 1:
                currentColor = "Yellow";
                sr.color = colorYellow;
                break;
            case 2:
                currentColor = "Pink";
                sr.color = colorPink;
                break;
            case 3:
                currentColor = "Purple";
                sr.color = colorPurple;
                break;

        }

    }
}
