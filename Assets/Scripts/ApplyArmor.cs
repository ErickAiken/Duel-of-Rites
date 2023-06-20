using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class ApplyArmor : MonoBehaviour
{


    private GameObject prefabArmorSet;
    private Transform newArmature;
    private Transform newParent;
    private GameObject descendant = null;
    private GameObject gameManager;
    private GameDataManager gameData;


    // Start is called before the first frame update
    void Start()
    {

        // Load in the game data
        gameManager = GameObject.Find("GameManager");
        gameData = gameManager.GetComponent<GameDataManager>();

        // Add the armor prefab to the scene
        GameObject prefabArmorSet = Instantiate(Resources.Load<GameObject>(gameData.GetArmorSetPath()));

        // Make the parent the players armor game object
        newParent = ReturnDecendantOfParent(gameObject, "Armors").transform;

        // Set the armors root model
        newArmature = ReturnDecendantOfParent(gameObject, "Root_M").transform;

        // Collect the armor from the prefab game object
        GameObject prefabArmor = ReturnDecendantOfParent(prefabArmorSet, "Armor");

        // For each armor under the prefab store the mesh renderer to list
        SkinnedMeshRenderer[] skinnedMeshRenderersList = new SkinnedMeshRenderer[prefabArmor.transform.childCount];
        for(int i = 0; i < prefabArmor.transform.childCount; i++)
        {
            GameObject gameObj = prefabArmor.transform.GetChild(i).gameObject;
            skinnedMeshRenderersList[i] = gameObj.GetComponent<SkinnedMeshRenderer>();

        }
        TransferSkinnedMeshes(skinnedMeshRenderersList);

        // Based on armor type, turn on/off body parts and underwear
        GameObject underwear = ReturnDecendantOfParent(this.gameObject, "Underwear");
        underwear.SetActive(false);

        GameObject legs = ReturnDecendantOfParent(this.gameObject, "Legs");
        legs.SetActive(false);

        // Get and apply the weapon
        GameObject weapon = Instantiate(Resources.Load<GameObject>(gameData.GetWeaponPath()), Vector3.zero, Quaternion.identity);
        switch(gameData.GetWeaponType())
        {
            case GameDataManager.WeaponType.DualHand:
                Transform twohandrest = ReturnDecendantOfParent(this.gameObject, "2H_REST").transform;
                weapon.transform.SetParent(twohandrest, false);
                break;
            default:
                break;
        }



    }//Start

    // Update is called once per frame
    void Update()
    {
        
    }

    private void TransferSkinnedMeshes(SkinnedMeshRenderer[] skinnedMeshRenderersList)
    {
        foreach (var t in skinnedMeshRenderersList)
        {
            string cachedRootBoneName = t.rootBone.name;
            var newBones = new Transform[t.bones.Length];
            for (var x = 0; x < t.bones.Length; x++)
                foreach (var newBone in newArmature.GetComponentsInChildren<Transform>())
                    if (newBone.name == t.bones[x].name)
                    {
                        newBones[x] = newBone;
                    }

            Transform matchingRootBone = GetRootBoneByName(newArmature, cachedRootBoneName);
            t.rootBone = matchingRootBone != null ? matchingRootBone : newArmature.transform;
            t.bones = newBones;
            Transform transform;
            (transform = t.transform).SetParent(newParent);
            transform.localPosition = Vector3.zero;
        }
    }

    static Transform GetRootBoneByName(Transform parentTransform, string name)
    {
        return parentTransform.GetComponentsInChildren<Transform>().FirstOrDefault(transformChild => transformChild.name == name);
    }

    private GameObject ReturnDecendantOfParent(GameObject parent, string descendantName)
    {
        foreach (Transform child in parent.transform)
        {                   
            if (child.name == descendantName)
            { 
                descendant = child.gameObject;                 
                break;
            }
            else
            {
                ReturnDecendantOfParent(child.gameObject, descendantName);
            }                  
        }
        return descendant;
    }

}//ApplyArmor
