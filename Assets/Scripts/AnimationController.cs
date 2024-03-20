using UnityEngine;

[RequireComponent (typeof(Animator))]
public class AnimationController : MonoBehaviour
{
    private Animator _animationsKnight;

    private void Start()
    {
        _animationsKnight = GetComponent<Animator>();
    }

    public void KnightRunOnAnimation()
    {
        _animationsKnight.SetBool("IsIdle", false);
        _animationsKnight.SetBool("IsRun", true);
        _animationsKnight.SetBool("IsAttack", false);
        _animationsKnight.SetBool("IsDeath", false);
    }

    public void KnightIdleOnAnimation()
    {
        _animationsKnight.SetBool("IsIdle", true);
        _animationsKnight.SetBool("IsRun", false);
        _animationsKnight.SetBool("IsAttack", false);
        _animationsKnight.SetBool("IsDeath", false);
    }

    public void KnightAttackOnAnimation()
    {
        _animationsKnight.SetBool("IsIdle", false);
        _animationsKnight.SetBool("IsRun", false);
        _animationsKnight.SetBool("IsAttack", true);
        _animationsKnight.SetBool("IsDeath", false);
    }
    public void KnightDeathOnAnimation()
    {
        _animationsKnight.SetBool("IsIdle", false);
        _animationsKnight.SetBool("IsRun", false);
        _animationsKnight.SetBool("IsAttack", false);
        _animationsKnight.SetBool("IsDeath", true);
    }

    public void SkeletonDeathOnAnimation()
    {
        _animationsKnight.SetBool("IsDeathSkeleton", true);
    }
}
