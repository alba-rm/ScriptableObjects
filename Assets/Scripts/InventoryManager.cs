using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//Examen
public class InventoryManager : MonoBehaviour
{
    public static InventoryManager instance;
    //Nombre del script
    public ScriptableItem[] weapons;
    public Text[] weaponsNames;
    public Image[] weaponsSprites;

    public InventorySlot[] weaponSlots;

    void Awake()
    {
        instance = this;
    }
    public void AddItem(ScriptableItem item)
    {
        for (int i = 0; i < weapons.Length; i++)
        {
            if(weapons[i] == null)
            {
                weapons[i] = item;
                weaponsNames[i].text = item.itemName;
                weaponsSprites[i].sprite = item.itemSprite;

                /*weaponSlots[i].slotItem = item;
                weaponSlots[i].slotNumber = i;*/

                return;
            }
        }
    }
}
