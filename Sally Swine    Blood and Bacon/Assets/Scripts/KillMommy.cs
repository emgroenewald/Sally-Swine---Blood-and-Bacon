using UnityEngine;

public class KillMommy : MonoBehaviour
{
    // Start is called before the first frame update
    public SpriteRenderer spriteRender;
    public Sprite Alive;
    public Sprite Dead;
    void Start()
    {
        if (MainManager.Inventory.Contains("DeadMommy"))
        {
            spriteRender.sprite = Dead;
        }
        else
        {
            spriteRender.sprite = Alive;
        }

    }
    public void KillMother()
    {
        //animation script

        //switch sprite
        spriteRender.sprite = Dead;

        MainManager.Inventory.Add("DeadMommy");
    }
    // Update is called once per frame
    void Update()
    {

    }
}
