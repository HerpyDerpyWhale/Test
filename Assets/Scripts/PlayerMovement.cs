using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float m_movementSpeed;
    public float m_sprintSpeed;
    public float m_rotationSpeed;
    public float m_jumpForce;

    private bool m_sprinting;
    CharacterController m_cc;

    // Start is called before the first frame update
    void Start()
    {
        m_cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Cursor.lockState = CursorLockMode.Locked;
        m_cc.Move(transform.forward * Input.GetAxis("Vertical") * m_movementSpeed * Time.deltaTime);
        m_cc.Move(transform.right * Input.GetAxis("Horizontal") * m_movementSpeed * Time.deltaTime);
        m_cc.SimpleMove(Physics.gravity);
        transform.Rotate(Vector3.up * Input.GetAxis("Mouse X") * m_rotationSpeed * Time.deltaTime);
        m_cc.Move(transform.up * Input.GetAxis("Jump") * m_jumpForce * Time.deltaTime);
    }
}
