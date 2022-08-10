using Unity;
using Unity.VisualScripting;
using UnityEngine;

/// <summary>
/// Toggles particle system
/// </summary>
[RequireComponent(typeof(ParticleSystem))]
public class ToggleParticle : MonoBehaviour
{
    private ParticleSystem _currentParticleSystem;
    private MonoBehaviour _currentOwner = null;

    private void OnEnable()
    {
        if (_currentParticleSystem)
        {
            ParticleSystem.MainModule main = _currentParticleSystem.main;
            main.playOnAwake = false;
        }
        _currentParticleSystem = GetComponent<ParticleSystem>();
    }

    public void Play()
    {
        _currentParticleSystem.Play();
    }

    public void Stop()
    {
        _currentParticleSystem.Stop();
    }

    public void PlayWithExclusivity(MonoBehaviour owner)
    {
        if(_currentOwner == null)
        {
            _currentOwner = this;
            Play();
        }
    }

    public void StopWithExclusivity(MonoBehaviour owner)
    {
        if(_currentOwner == this)
        {
            _currentOwner = null;
            Stop();
        }
    }

}
