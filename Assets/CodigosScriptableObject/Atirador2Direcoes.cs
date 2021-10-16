using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Atirador", menuName = "Inimigo/Atirador/DuasDirecoes", order = 2)]
public class Atirador2Direcoes : Atirador
{
    public override void Mover()
    {
        _objeto.transform.Rotate(new Vector3(0, 0, 20) * Time.deltaTime);

    }
    public override IEnumerator _Atacar()
    {
        while (true)
        {
            GameObject projetil1 = Instantiate(projetil, _objeto.transform.position, Quaternion.identity);
            projetil1.GetComponent<Rigidbody2D>().velocity = _objeto.transform.right * 5f;

            GameObject projetil2 = Instantiate(projetil, _objeto.transform.position, Quaternion.identity);
            projetil2.GetComponent<Rigidbody2D>().velocity = -_objeto.transform.right * 5f;

            yield return new WaitForSeconds(Random.Range(0.5f, 1.5f));
        }
        
        /*

        Vector3 targ = Jogador.jogador.transform.position;
        targ.z = 0f;
        Vector3 objectPos = aux.transform.position;
        targ.x = targ.x - objectPos.x;
        targ.y = targ.y - objectPos.y;
        float angle = Mathf.Atan2(targ.y, targ.x) * Mathf.Rad2Deg;
        aux.transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));

        aux.GetComponent<Rigidbody2D>().velocity = aux.transform.right * 5f;
        
        */
    }
}
