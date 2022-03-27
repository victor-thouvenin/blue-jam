using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    public GameObject hole;
    public GameObject sprite;

    float posX = 0;
    float posY = 0;
    float move = 0;

    Vector3 pos;
    float distance;
    float damage = 0f;
    float time = 0f;
    float color = 255f;
    void Start()
    {
        Cursor.visible = false;
    }

    void Update()
    {
        move = Input.GetAxis("Mouse Y");
        if (posY+move > -4.5 && posY+move <= 4.5)
        {
            posY += move;
        }
        distance = Vector2.Distance(transform.position, hole.transform.position) -12;
    }

    void FixedUpdate()
    {
        time += Time.deltaTime;
        if (distance < 5f && color > 0)
        {
            getDamage();
        } 
        if (time >= 1f)
        {
            time -= 1f;
        }
        pos = new Vector2 (posX, posY);
        if (posY > -4.5 && posY < 4.5)
        {
            transform.position = pos;
        }
    }

    void getDamage()
    {
        SpriteRenderer renderer;
        damage += (5f-distance)*Time.deltaTime;
        if (damage >= 1f)
        {
            color -= 1f;
            damage -= 1f;
            renderer = sprite.GetComponent<SpriteRenderer>();
            renderer.color = new Color (0, 0, color/255f);
        }
        // game_over();
    }
}
