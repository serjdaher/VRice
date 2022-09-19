using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

namespace Watering
{

    public class WaterCollision : MonoBehaviour
    {
        private ParticleSystem water;
        //public List<ParticleCollisionEvent> particleCollisionEvents;

        private void OnEnable()
        {
            water = GetComponent<ParticleSystem>();
            //particleCollisionEvents = new List<ParticleCollisionEvent>();
        }

        private void OnParticleCollision(GameObject other)
        {
            //int safeSize = water.GetSafeCollisionEventSize();
            //int numCollision = water.GetCollisionEvents(other, particleCollisionEvents);
            //if(particleCollisionEvents.Count < safeSize)
            //{
            //    particleCollisionEvents = new List<ParticleCollisionEvent>(safeSize);
            //}
            if (other.layer == 8)
            {
                other.GetComponent<ChangeColor>().ColorChange(other, new Color(0.3301887f, 0.2544829f, 0.2099501f));
                if (other.transform.GetChild(0).GetComponent<XRSocketInteractor>().hasSelection)
                {
                    other.transform.GetChild(1).gameObject.SetActive(true);
                    other.transform.GetChild(0).GetComponent<XRSocketInteractor>().firstInteractableSelected.transform.gameObject.SetActive(false);
                }
            }
            //else if (other.layer == 10)
            //{
            //    other.GetComponent<EnableChild>().ActivatePlant(other,1);

            //}
        }
    }
}


