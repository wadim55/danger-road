
using UnityEngine;

[CreateAssetMenu(fileName = "castorCar")]
public class Item : ScriptableObject
{
 [SerializeField] private string model;
 public Mesh bodyCar;
 [SerializeField] private Mesh FLW;
 [SerializeField] private Mesh FRW;
 [SerializeField] private Mesh BLW;
 [SerializeField] private Mesh BRW;
 [SerializeField] private Material bodyMaterial;
 [SerializeField] private Material lightMaterial;
 [SerializeField] private Material whileMaterial;
 
}
