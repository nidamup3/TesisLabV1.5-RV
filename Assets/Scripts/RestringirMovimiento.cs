using UnityEngine;

public class RestringirMovimiento : MonoBehaviour
{
    private Rigidbody m_Rigidbody;

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();

        // Establecer la posición inicial en el eje Z a uno de los valores permitidos
        m_Rigidbody.position = new Vector3(m_Rigidbody.position.x, m_Rigidbody.position.y, -10.8f);
    }

    void Update()
    {
        // Obtener la posición actual en el eje Z
        float posicionZ = m_Rigidbody.position.z;

        // Restringir la posición en Z a los valores permitidos
        float[] valoresPermitidos = { -10.8f, -8.6f, -6.6f, -4.4f, -2.2f };
        float valorCercano = EncontrarValorCercano(valoresPermitidos, posicionZ);
        m_Rigidbody.position = new Vector3(m_Rigidbody.position.x, m_Rigidbody.position.y, valorCercano);

        // Si deseas restringir el movimiento del RigidBody, puedes hacerlo de la siguiente manera:
        // m_Rigidbody.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY;
    }

    float EncontrarValorCercano(float[] valores, float valor)
    {
        float valorCercano = valores[0];
        float distanciaMinima = Mathf.Abs(valor - valores[0]);

        foreach (float val in valores)
        {
            float distancia = Mathf.Abs(valor - val);
            if (distancia < distanciaMinima)
            {
                distanciaMinima = distancia;
                valorCercano = val;
            }
        }

        return valorCercano;
    }
}
