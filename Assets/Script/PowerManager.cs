using System.Collections;
using System.Collections.Generic;
using System.Linq;
using StarterAssets;
using UnityEngine;

public class PowerManager : MonoBehaviour
{
    public ThirdPersonController thirdPersonController;
    public CharacterController characterController;
    public Collider player;
    private List<Power> powersInventory = new List<Power> { };

    public bool SetPower(Power power)
    {
        try
        {
            powersInventory.Add(power);
            Debug.Log(power);

            switch (power)
            {
                case Power.Fast:
                    ToggleFastPower();
                    break;
                case Power.Tall:
                    ToggleTallPower();
                    break;
                case Power.SuperJump:
                    ToggleSuperJumpPower();
                    break;
                case Power.Small:
                    ToggleSmallPower();
                    break;
                default:
                    Debug.Log("Power is not config");
                    break;
            }
            StartCoroutine(RemovePower());

            return true;
        }
        catch (System.Exception)
        {
            return false;
        }
    }

    private Power GetRandomPower()
    {
        Power[] powers = { Power.Fast, Power.Tall, Power.SuperJump, Power.Small };

        // Create an instance of Random
        System.Random random = new System.Random();

        // Generate a random index within the bounds of the array
        int randomIndex = random.Next(0, powers.Length);

        // Retrieve the element at the random index
        Power randomPower = powers[randomIndex];

        return randomPower;
    }

    private IEnumerator RemovePower()
    {
        yield return new WaitForSeconds(30.0f);
        Debug.Log("Power remove");
        int nbValues = powersInventory.Count(n => n == powersInventory[0]);
        Debug.Log(nbValues);
        if (nbValues < 2f && nbValues > 0)
        {
            switch (powersInventory[0])
            {
                case Power.Fast:
                    ToggleFastPower(true);
                    break;
                case Power.Tall:
                    ToggleTallPower(true);
                    break;
                case Power.SuperJump:
                    ToggleSuperJumpPower(true);
                    break;
                case Power.Small:
                    ToggleSmallPower(true);
                    break;
                default:
                    Debug.Log("Power is not config");
                    break;
            }
        }
        powersInventory.Remove(powersInventory[0]);
    }

    private void ToggleFastPower(bool disable = false)
    {
        if (disable)
        {
            thirdPersonController.SprintSpeed = 10f;
        }
        else
        {
            thirdPersonController.SprintSpeed = 20f;
        }
    }

    private void ToggleTallPower(bool disable = false)
    {
        if (disable)
        {
            player.transform.localScale = new Vector3(1, 1, 1);
            characterController.center = new Vector3(0f, 1.05f, 0.08f);
        }
        else
        {
            player.transform.localScale = new Vector3(2, 2, 2);
            characterController.center = new Vector3(0f, 1.09f, 0.08f);
        }
    }

    private void ToggleSmallPower(bool disable = false)
    {
        if (disable)
        {
            player.transform.localScale = new Vector3(1, 1, 1);
            characterController.center = new Vector3(0f, 1.05f, 0.08f);
        }
        else
        {
            player.transform.localScale = new Vector3(0.25f, 0.25f, 0.25f);
            characterController.center = new Vector3(0f, 0.99f, 0.08f);
        }
    }

    private void ToggleSuperJumpPower(bool disable = false)
    {
        if (disable)
        {
            thirdPersonController.JumpHeight = 1.2f;
        }
        else
        {
            thirdPersonController.JumpHeight = 12.0f;
        }
    }
}
