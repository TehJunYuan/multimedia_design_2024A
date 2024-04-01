using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int rubbish = 0;
    [SerializeField] private Text rubbishText;
    [SerializeField] private AudioSource collectionSoundEffect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Rubbish"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            rubbish++;
            rubbishText.text = "Rubbish: " + rubbish;
        }
    }
}
