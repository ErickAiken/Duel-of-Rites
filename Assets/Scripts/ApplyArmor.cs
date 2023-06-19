using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class ApplyArmor : MonoBehaviour
{


    public GameObject prefabArmorSet;
    private Transform newArmature;
    private Transform newParent;
    private GameObject descendant = null;


    // Start is called before the first frame update
    void Start()
    {
        // Make the parent the players armor game object
        newParent = ReturnDecendantOfParent(gameObject, "Armors").transform;

        // Set the armors root model
        newArmature = ReturnDecendantOfParent(gameObject, "Root_M").transform;

        // Collect the armor from the prefab game object
        GameObject prefabArmor = ReturnDecendantOfParent(prefabArmorSet, "Armor");

        // For each armor under the prefab store the mesh renderer to list
        SkinnedMeshRenderer[] skinnedMeshRenderersList = new SkinnedMeshRenderer[prefabArmor.transform.GetChildCount()];
        for(int i = 0; i < prefabArmor.transform.GetChildCount(); i++)
        {
            GameObject gameObj = prefabArmor.transform.GetChild(i).gameObject;
            skinnedMeshRenderersList[i] = gameObj.GetComponent<SkinnedMeshRenderer>();

        }
        TransferSkinnedMeshes(skinnedMeshRenderersList);
    }

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
