using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MainManager : MonoBehaviour
{

    public static Dictionary<string, bool> DialogDict = new Dictionary<string, bool>();
    public static List<string> Inventory = new List<string>();
    public static bool LivingRoom = false;
    public static bool MudPile;
    public static Dictionary<string, bool> Slots = new Dictionary<string, bool>() { { "Red", false }, { "Green", false }, { "Blue", false } };
    public static MainManager Instance;
    public static Vector3 SallyPosition;


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
