using UnityEngine;
using UnityEngine.UI;
[CreateAssetMenu(menuName = "CARDS")]


public class SO_CardTypes : ScriptableObject
{
    public enum DialogueTypes
    {
        Dialogue1,
        Dialogue2,
        Dialogue3,
        Dialogue4
    }
    public DialogueTypes dialogues;
    public string name;
    public Sprite sprite;


}
