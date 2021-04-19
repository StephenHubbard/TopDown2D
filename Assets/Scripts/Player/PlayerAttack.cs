using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public Animator animator;
    private bool isAttacking = false;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        Attack();
    }

    private void Attack()
    {
        if (Input.GetMouseButtonDown(0) && !isAttacking)
        {
            StartCoroutine(AttackCo());
        }
    }

    private IEnumerator AttackCo()
    {
        animator.SetTrigger("attack");
        isAttacking = true;
        yield return new WaitForSeconds(.3f);
        isAttacking = false;
    }

    public bool GetIsAttackingBool()
    {
        return isAttacking;
    }

}
