using System.Collections;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class FocusFoward : MonoBehaviour
{
    [Header("Options")]
    public float minDistance = 0.1f;
    public float maxDistance = 15f;
    public float focusSpeed = 0.15f;
    public bool useSphereCast = true;
    public float sphereCastRadius = 0.5f;

    private PostProcessVolume _volume;
    private DepthOfField _depthOfField;
    private Coroutine _focusCoroutine;
    private float _targetDistance;

    private PostProcessVolume Volume => GetPostProcessVolume();
    private DepthOfField DepthOfField => _depthOfField ??= Volume.profile.GetSetting<DepthOfField>();

    private PostProcessVolume GetPostProcessVolume()
    {
        if (_volume != null) return _volume;

        // Use FindObjectsByType instead of FindObjectsOfType
        var volumes = FindObjectsByType<PostProcessVolume>(FindObjectsSortMode.None);
        if (volumes.Length == 0)
        {
            Debug.LogError("No Post Process Volume found!");
            return null;
        }

        _volume = volumes[0];
        return _volume;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Volume == null) return;

        CheckFocus();
    }

    private void CheckFocus()
    {
        var hitInfo = CalculateHit();
        if(!hitInfo.HasValue)
        {
            SwitchFocus(maxDistance);
            return;
        }

        var focusDistance = CalculateFocusDistance(hitInfo.Value);
        SwitchFocus(focusDistance);
    }

    private float CalculateFocusDistance(RaycastHit hitInfo)
    {
        var distance = Vector3.Distance(transform.position, hitInfo.point);
        return Mathf.Clamp(distance, minDistance, maxDistance);
    }

    private void SwitchFocus(float newTargetDistance)
    {
        if (Mathf.Approximately(DepthOfField.focusDistance.value, newTargetDistance)) return;
        if (Mathf.Approximately(_targetDistance, newTargetDistance)) return;

        _targetDistance = newTargetDistance;

        if (_focusCoroutine != null) return;
        _focusCoroutine = StartCoroutine(SetFocusDistance());
    }

    private IEnumerator SetFocusDistance()
    {
        var elapsed = 0f;
        var startvalue = DepthOfField.focusDistance.value;

        while(elapsed < focusSpeed)
        {
            DepthOfField.focusDistance.value = Mathf.Lerp(startvalue, _targetDistance, elapsed / focusSpeed);
            elapsed += Time.deltaTime;

            yield return null;
        }

        DepthOfField.focusDistance.value = _targetDistance;

        _focusCoroutine = null;
    }

    private RaycastHit? CalculateHit()
    {
        var thisTransform = transform;
        var hit = useSphereCast
            ? Physics.SphereCast(thisTransform.position
                , sphereCastRadius
                , thisTransform.forward
                , out var hitInfo, maxDistance)
            : Physics.Raycast(thisTransform.position
                , thisTransform.forward
                , out hitInfo, maxDistance);

        return hit ? hitInfo : null;
    }
}
