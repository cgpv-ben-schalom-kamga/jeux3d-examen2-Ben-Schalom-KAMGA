using System;
using UnityEngine;

public class Piece : MonoBehaviour
{
    [SerializeField, Tooltip("Référence à la boule.")]
    private Boule boule;


    /// <summary>
    /// Increments the collected-piece count when the collider has the "Boule" tag.
    /// </summary>
    /// <param name="other">The collider to check for the "Boule" tag.</param>
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Boule"))
        {
            boule.AjouterNombreDePieceCollecter();
            Destroy(gameObject); 
        }
    }
}
