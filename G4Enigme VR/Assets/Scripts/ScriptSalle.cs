using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptSalle : MonoBehaviour
{
    List<List<GestionPressurePlate>> tiles = new List<List<GestionPressurePlate>>();
    List<GestionPressurePlate> toSave = new List<GestionPressurePlate>();
    GestionPressurePlate last;
    int nextValue;
    public GameObject DOOR;


    // Start is called before the first frame update
    void Start()
    {
        nextValue = 1;
        for(int i = 0; i < 5; i++)
        {
            tiles.Add(new List<GestionPressurePlate>());
            for(int j = 0; j<11; j++)
            {
                tiles[i].Add(GameObject.Find("tiles/Build Base Roof01 Single (" + ((i + j * 5) + 1) + ")").GetComponent<GestionPressurePlate>());
            }
        }
    }

    public void trigger(int h, int l, int value)
    {
        print("val :"
             +value +
             " nextVal :"
             +nextValue
             +"h :" +
             h
             +"l :" +
             l);

        if ((toSave.Count == 0 && tiles[l][h] == tiles[0][0]) || (value == nextValue && ((h == last.h+1 ^ h == last.h-1) ^ (l == last.l + 1 ^ l == last.l - 1))))
        {
            toSave.Add(tiles[l][h]);
            last = tiles[l][h];
            tiles[l][h].enfoncer();
            nextValue++;
            if(nextValue == 4)
            {
                nextValue = 1;
            }
            if(tiles[3][10] == tiles[l][h])
            {
                //trigger porte
                DOOR.GetComponent<PorteScriptZ>().bougerPorte = true;
                print("reussi");
            }
        } else
        {
            foreach(GestionPressurePlate tile in toSave)
            {
                tile.relever();
            }
            toSave.Clear();
            nextValue = 1;
            last = null;
        }
        

    }
}
