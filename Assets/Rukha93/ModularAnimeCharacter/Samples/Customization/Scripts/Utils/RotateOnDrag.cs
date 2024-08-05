using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Rukha93.ModularAnimeCharacter.Customization.Utils
{
    public class RotateOnDrag : MonoBehaviour
    {
        [SerializeField] private float m_RotateSpeed = 1;

        private bool m_SmoothRotate;
        private Vector2 m_LastMousePosition;
        private float m_RotationRemaining;

        // Update is called once per frame
        void Update()
        {
            //character rotation
            //if (ControlFreak2.CF2Input.GetMouseButtonDown(0))
            //{
            //    m_LastMousePosition = new Vector2(ControlFreak2.CF2Input.mousePosition.x / Screen.width, ControlFreak2.CF2Input.mousePosition.y / Screen.height);
            //    m_SmoothRotate = !UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject();
            //}
            //else if (ControlFreak2.CF2Input.GetMouseButtonUp(0))
            //{
            //    m_SmoothRotate = true;
            //}

            //if (m_SmoothRotate && ControlFreak2.CF2Input.GetMouseButton(0))
            //{
            //    var pos = new Vector2(ControlFreak2.CF2Input.mousePosition.x / Screen.width, ControlFreak2.CF2Input.mousePosition.y / Screen.height);
            //    Vector2 delta = pos - m_LastMousePosition;
            //    m_LastMousePosition = pos;

            //    transform.Rotate(0, -delta.x * m_RotateSpeed * 100, 0);
            //    m_RotationRemaining = -delta.x * m_RotateSpeed * 100 * (1 / Time.deltaTime);
            //}
            //else
            //{
            //    transform.Rotate(0, m_RotationRemaining * Time.deltaTime, 0);
            //    m_RotationRemaining = Mathf.Lerp(m_RotationRemaining, 0, Time.deltaTime * 4);
            //}
        }
    }
}