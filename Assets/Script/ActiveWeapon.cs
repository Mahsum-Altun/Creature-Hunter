using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations.Rigging;
using UnityEngine.UI;

public class ActiveWeapon : MonoBehaviour
{
    public float turnSpeed;
    public float aimDuration;
    public Rig aimLayer;
    public Animator weaponAnimator;

    bool weaponAnim;
    bool isHolsteredPistol;
    bool isHolsteredM4;
    bool isHolsteredShotgun;
    bool pistolRecoil;
    bool m4Recoil;
    bool shotgunRecoil;


    void Start()
    {

    }


    private void Update()
    {
        if (weaponAnim == true)
        {
            aimLayer.weight += Time.deltaTime / aimDuration;
        }
    }

    public void Pistol()
    {
        aimLayer.weight = 0f;
        isHolsteredPistol = true;
        isHolsteredM4 = false;
        isHolsteredShotgun = false;
        weaponAnim = true;
        weaponAnimator.SetBool("Pistol", isHolsteredPistol);
        weaponAnimator.SetBool("M4", isHolsteredM4);
        weaponAnimator.SetBool("Shotgun", isHolsteredShotgun);
    }
    public void M4()
    {
        aimLayer.weight = 0f;
        isHolsteredM4 = true;
        isHolsteredPistol = false;
        isHolsteredShotgun = false;
        weaponAnim = true;
        weaponAnimator.SetBool("M4", isHolsteredM4);
        weaponAnimator.SetBool("Pistol", isHolsteredPistol);
        weaponAnimator.SetBool("Shotgun", isHolsteredShotgun);
    }
    public void Shotgun()
    {
        aimLayer.weight = 0f;
        isHolsteredShotgun = true;
        isHolsteredPistol = false;
        isHolsteredM4 = false;
        weaponAnim = true;
        weaponAnimator.SetBool("Shotgun", isHolsteredShotgun);
        weaponAnimator.SetBool("Pistol", isHolsteredPistol);
        weaponAnimator.SetBool("M4", isHolsteredM4);
    }
    public void WeaponBamBam()
    {


        if (isHolsteredPistol == true)
        {
            pistolRecoil = true;
            m4Recoil = false;
            shotgunRecoil = false;
            weaponAnimator.SetBool("PistolRecoil", pistolRecoil);
            weaponAnimator.SetBool("ShotgunRecoil", shotgunRecoil);
            weaponAnimator.SetBool("M4Recoil", m4Recoil);
        }
        else if (isHolsteredM4 == true)
        {
            pistolRecoil = false;
            m4Recoil = true;
            shotgunRecoil = false;
            weaponAnimator.SetBool("PistolRecoil", pistolRecoil);
            weaponAnimator.SetBool("ShotgunRecoil", shotgunRecoil);
            weaponAnimator.SetBool("M4Recoil", m4Recoil);
        }
        else if (isHolsteredShotgun == true)
        {
            pistolRecoil = false;
            m4Recoil = false;
            shotgunRecoil = true;
            weaponAnimator.SetBool("PistolRecoil", pistolRecoil);
            weaponAnimator.SetBool("ShotgunRecoil", shotgunRecoil);
            weaponAnimator.SetBool("M4Recoil", shotgunRecoil);
        }

    }

    public void WeaponBamBamClosss()
    {
        pistolRecoil = false;
        m4Recoil = false;
        shotgunRecoil = false;
        weaponAnimator.SetBool("PistolRecoil", pistolRecoil);
        weaponAnimator.SetBool("M4Recoil", m4Recoil);
        weaponAnimator.SetBool("ShotgunRecoil", shotgunRecoil);


    }

}
