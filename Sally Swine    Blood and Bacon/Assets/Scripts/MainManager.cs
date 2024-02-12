using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{

    public static Dictionary<string, bool> DialogDict = new Dictionary<string, bool>();
    public static List<string> Inventory = new List<string>();
    public static bool LivingRoom = false;
    public static bool MudPile;

    public static MainManager Instance;


    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
