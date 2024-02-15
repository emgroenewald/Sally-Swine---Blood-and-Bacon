using UnityEngine;

public class DeadPappa : MonoBehaviour
{
    // Start is called before the first frame update
    public SpriteRenderer spriteRender;
    public Sprite Alive;
    public Sprite Dead;
    void Start()
    {
        if (MainManager.Inventory.Contains("DeadPappa"))
        {
            spriteRender.sprite = Dead;
        }
        else
        {
            spriteRender.sprite = Alive;
        }

    }
    public void KillPappa()
    {
        //animation script

        //switch sprite
        spriteRender.sprite = Dead;

        MainManager.Inventory.Add("DeadPappa");
    }
    // Update is called once per frame
    void Update()
    {

    }
}
