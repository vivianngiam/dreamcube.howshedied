using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class BallInteractionArea : MonoBehaviour
{
    public ParticleSystem particles;

    private bool _isActive = false;
    private bool _ballInArea = false;

    protected const float _timeToActivate = 0.75f;
    private float _elapsedTime = 0;

    private void Update()
    {
        if (_isActive == true && _ballInArea == true)
        {
            _elapsedTime += Time.deltaTime;

            if (_elapsedTime > _timeToActivate)
            {
                //this may keep firing if we don't do anything about it
                 TriggerAction();
            }
        }
    }

    public void Setup()
    {
        transform.localScale = Vector3.one;
    }

    public void Activate()
    {
        _isActive = true;
        _ballInArea = false;

        particles.gameObject.SetActive(true);
        particles.Play();

        _elapsedTime = 0;
    }

    public void Deactivate()
    {
        _isActive = false;
        _ballInArea = false;

        particles.gameObject.SetActive(false);
        particles.Stop();
    }

    public virtual void TriggerAction()
    {
        //override this with something interesting
    }

    private void OnTriggerStay(Collider other)
    {
        if (_isActive == false) return;

        if (other.CompareTag("Ball"))
        {
            if (_ballInArea == false)
            {
                transform.DOScale(Vector3.one * 0.9f, 0.1f);
            }
            _ballInArea = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (_isActive == false) return;

        if (other.CompareTag("Ball"))
        {
            _ballInArea = false;
            _elapsedTime = 0;

            transform.DOScale(Vector3.one, 0.1f);
        }
    }
}
