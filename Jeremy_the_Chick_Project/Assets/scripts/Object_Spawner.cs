using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Spawner : MonoBehaviour
{
    public GameObject egg;
    public GameObject fire;

    public void SpawnEggs(World_Piece worldPiece)
    {
        // 80% of the time, spawn eggs
        if (Random.value < .8)
        {
            //make eggs
            for (int numEgg = 0; numEgg < Random.Range(1, 4); numEgg++)
            {
                Vector3 right = worldPiece.rightAnchor.position;
                Vector3 left = worldPiece.leftAnchor.position;

                //if there is no hieght change in the world piece, spawn eggs
                if (right.y == left.y)
                {
                    Vector3 eggLocation = new Vector3(Random.Range(left.x, right.x), Random.Range(left.y + 2, right.y + 5), 0f);
                    Instantiate(egg, eggLocation, Quaternion.identity);
                }
            }
        }
    }

    public void SpawnFire(World_Piece worldPiece, Vector3 jeremyPosition)
    {
        //Debug.Log(worldPiece.name);
        if(jeremyPosition.x >= 250 && jeremyPosition.x < 1500 && Random.value <= .3)
        //if(Random.value < .5)
        {
            Debug.Log("spawing fire early");

            if (worldPiece.name == "ground_3(Clone)")
            {
                Vector3 right = worldPiece.rightAnchor.position;
                Vector3 left = worldPiece.leftAnchor.position;

                List<float> nums = new List<float>();
                nums.Insert(0, 100);
                nums.Insert(Random.Range(0, nums.Count), 50);
                nums.Insert(Random.Range(0, nums.Count), 10);

                if (Random.Range(0, 100) <= nums[0])
                {
                    Debug.Log(nums[0]);
                    Vector3 fireLocation1 = new Vector3(Random.Range(left.x, left.x + 2.5f), left.y + 0.91f, 0f);
                    Instantiate(fire, fireLocation1, Quaternion.identity);
                }
                if (Random.Range(0, 100) <= nums[1])
                {
                    Debug.Log(nums[1]);
                    Vector3 fireLocation2 = new Vector3(Random.Range(left.x + 3.5f, left.x + 7.5f), left.y + 1.35f, 0f);
                    Instantiate(fire, fireLocation2, Quaternion.identity);
                }
                if (Random.Range(0, 100) <= nums[2])
                {
                    Debug.Log(nums[2]);
                    Vector3 fireLocation3 = new Vector3(Random.Range(left.x + 8.5f, right.x), left.y + 0.91f, 0f);
                    Instantiate(fire, fireLocation3, Quaternion.identity);
                }
            }

            if (worldPiece.name == "ground_4(Clone)")
            {
                Vector3 right = worldPiece.rightAnchor.position;
                Vector3 left = worldPiece.leftAnchor.position;

                for (int numFire = 0; numFire < Random.Range(1, 2); numFire++)
                {
                    Vector3 fireLocation = new Vector3(Random.Range(left.x, right.x), left.y + 0.91f, 0f);
                    Instantiate(fire, fireLocation, Quaternion.identity);
                }
            }

            if (worldPiece.name == "ground_5(Clone)")
            {
                Vector3 right = worldPiece.rightAnchor.position;
                Vector3 left = worldPiece.leftAnchor.position;

                List<float> nums = new List<float>();
                nums.Insert(0, 100);
                nums.Insert(Random.Range(0, nums.Count), 30);

                if (Random.Range(0, 100) <= nums[0])
                {
                    Debug.Log(nums[0]);
                    Vector3 fireLocation1 = new Vector3(Random.Range(left.x, left.x + 4.5f), left.y + 0.91f, 0f);
                    Instantiate(fire, fireLocation1, Quaternion.identity);
                }
                if (Random.Range(0, 100) <= nums[1])
                {
                    Debug.Log(nums[1]);
                    Vector3 fireLocation2 = new Vector3(Random.Range(left.x + 7.5f, right.x), left.y + 0.91f, 0f);
                    Instantiate(fire, fireLocation2, Quaternion.identity);
                }
            }

            if (worldPiece.name == "ground_6(Clone)")
            {
                Vector3 right = worldPiece.rightAnchor.position;
                Vector3 left = worldPiece.leftAnchor.position;

                List<float> nums = new List<float>();
                nums.Insert(0, 100);
                nums.Insert(Random.Range(0, nums.Count), 30);

                if (Random.Range(0, 100) <= nums[0])
                {
                    Debug.Log(nums[0]);
                    Vector3 fireLocation1 = new Vector3(Random.Range(left.x, left.x + 3.5f), left.y + 0.91f, 0f);
                    Instantiate(fire, fireLocation1, Quaternion.identity);
                }
                if (Random.Range(0, 100) <= nums[1])
                {
                    Debug.Log(nums[1]);
                    Vector3 fireLocation2 = new Vector3(Random.Range(left.x + 4.5f, left.x + 7.5f), left.y + 1.91f, 0f);
                    Instantiate(fire, fireLocation2, Quaternion.identity);
                }
            }

            if (worldPiece.name == "ground_7(Clone)")
            {
                Vector3 right = worldPiece.rightAnchor.position;
                Vector3 left = worldPiece.leftAnchor.position;

                List<float> nums = new List<float>();
                nums.Insert(0, 100);
                nums.Insert(Random.Range(0, nums.Count), 50);
                nums.Insert(Random.Range(0, nums.Count), 10);

                if (Random.Range(0, 100) <= nums[0])
                {
                    Debug.Log(nums[0]);
                    Vector3 fireLocation1 = new Vector3(Random.Range(left.x, left.x + 4.5f), left.y + 0.91f, 0f);
                    Instantiate(fire, fireLocation1, Quaternion.identity);
                }
                if (Random.Range(0, 100) <= nums[1])
                {
                    Debug.Log(nums[1]);
                    Vector3 fireLocation2 = new Vector3(Random.Range(left.x + 7.5f, left.x + 11.5f), left.y + 0.91f, 0f);
                    Instantiate(fire, fireLocation2, Quaternion.identity);
                }
                if (Random.Range(0, 100) <= nums[2])
                {
                    Debug.Log(nums[2]);
                    Vector3 fireLocation3 = new Vector3(Random.Range(left.x + 14.5f, right.x), left.y + 0.91f, 0f);
                    Instantiate(fire, fireLocation3, Quaternion.identity);
                }
            }

            if (worldPiece.name == "ground_8(Clone)")
            {
                Vector3 right = worldPiece.rightAnchor.position;
                Vector3 left = worldPiece.leftAnchor.position;

                List<float> nums = new List<float>();
                nums.Insert(0, 100);
                nums.Insert(Random.Range(0, nums.Count), 50);
                nums.Insert(Random.Range(0, nums.Count), 15);
                nums.Insert(Random.Range(0, nums.Count), 5);


                if (Random.Range(0, 100) <= nums[0])
                {
                    Debug.Log(nums[0]);
                    Vector3 fireLocation1 = new Vector3(Random.Range(left.x, left.x + 3.5f), left.y + 0.91f, 0f);
                    Instantiate(fire, fireLocation1, Quaternion.identity);
                }

                if (Random.Range(0, 100) <= nums[1])
                {
                    Debug.Log(nums[1]);
                    Vector3 fireLocation2 = new Vector3(Random.Range(left.x + 6.5f, left.x + 10.5f), left.y + 0.91f, 0f);
                    Instantiate(fire, fireLocation2, Quaternion.identity);
                }

                if (Random.Range(0, 100) <= nums[2])
                {
                    Debug.Log(nums[2]);
                    Vector3 fireLocation3 = new Vector3(Random.Range(left.x + 13.5f, left.x + 17.5f), left.y + 0.91f, 0f);
                    Instantiate(fire, fireLocation3, Quaternion.identity);
                }
                if (Random.Range(0, 100) <= nums[3])
                {
                    Debug.Log(nums[3]);
                    Vector3 fireLocation4 = new Vector3(Random.Range(left.x + 20.5f, right.x), left.y + 0.91f, 0f);
                    Instantiate(fire, fireLocation4, Quaternion.identity);
                }
            }
        }

        if(jeremyPosition.x >= 1500 && Random.value <= .6)
        {
            Debug.Log("spawing fire late");

            if (worldPiece.name == "ground_3(Clone)")
            {
                Vector3 right = worldPiece.rightAnchor.position;
                Vector3 left = worldPiece.leftAnchor.position;

                List<float> nums = new List<float>();
                nums.Insert(0, 100);
                nums.Insert(Random.Range(0, nums.Count), 50);
                nums.Insert(Random.Range(0, nums.Count), 10);

                if (Random.Range(0, 100) <= nums[0])
                {
                    Debug.Log(nums[0]);
                    Vector3 fireLocation1 = new Vector3(Random.Range(left.x, left.x + 2.5f), left.y + 0.91f, 0f);
                    Instantiate(fire, fireLocation1, Quaternion.identity);
                }
                if (Random.Range(0, 100) <= nums[1])
                {
                    Debug.Log(nums[1]);
                    Vector3 fireLocation2 = new Vector3(Random.Range(left.x + 3.5f, left.x + 7.5f), left.y + 1.35f, 0f);
                    Instantiate(fire, fireLocation2, Quaternion.identity);
                }
                if (Random.Range(0, 100) <= nums[2])
                {
                    Debug.Log(nums[2]);
                    Vector3 fireLocation3 = new Vector3(Random.Range(left.x + 8.5f, right.x), left.y + 0.91f, 0f);
                    Instantiate(fire, fireLocation3, Quaternion.identity);
                }
            }

            if (worldPiece.name == "ground_4(Clone)")
            {
                Vector3 right = worldPiece.rightAnchor.position;
                Vector3 left = worldPiece.leftAnchor.position;

                for (int numFire = 0; numFire < Random.Range(1, 2); numFire++)
                {
                    Vector3 fireLocation = new Vector3(Random.Range(left.x, right.x), left.y + 0.91f, 0f);
                    Instantiate(fire, fireLocation, Quaternion.identity);
                }
            }

            if (worldPiece.name == "ground_5(Clone)")
            {
                Vector3 right = worldPiece.rightAnchor.position;
                Vector3 left = worldPiece.leftAnchor.position;

                List<float> nums = new List<float>();
                nums.Insert(0, 100);
                nums.Insert(Random.Range(0, nums.Count), 30);

                if (Random.Range(0, 100) <= nums[0])
                {
                    Debug.Log(nums[0]);
                    Vector3 fireLocation1 = new Vector3(Random.Range(left.x, left.x + 4.5f), left.y + 0.91f, 0f);
                    Instantiate(fire, fireLocation1, Quaternion.identity);
                }
                if (Random.Range(0, 100) <= nums[1])
                {
                    Debug.Log(nums[1]);
                    Vector3 fireLocation2 = new Vector3(Random.Range(left.x + 7.5f, right.x), left.y + 0.91f, 0f);
                    Instantiate(fire, fireLocation2, Quaternion.identity);
                }
            }

            if (worldPiece.name == "ground_6(Clone)")
            {
                Vector3 right = worldPiece.rightAnchor.position;
                Vector3 left = worldPiece.leftAnchor.position;

                List<float> nums = new List<float>();
                nums.Insert(0, 100);
                nums.Insert(Random.Range(0, nums.Count), 30);

                if (Random.Range(0, 100) <= nums[0])
                {
                    Debug.Log(nums[0]);
                    Vector3 fireLocation1 = new Vector3(Random.Range(left.x, left.x + 3.5f), left.y + 0.91f, 0f);
                    Instantiate(fire, fireLocation1, Quaternion.identity);
                }
                if (Random.Range(0, 100) <= nums[1])
                {
                    Debug.Log(nums[1]);
                    Vector3 fireLocation2 = new Vector3(Random.Range(left.x + 4.5f, left.x + 7.5f), left.y + 1.91f, 0f);
                    Instantiate(fire, fireLocation2, Quaternion.identity);
                }
            }

            if (worldPiece.name == "ground_7(Clone)")
            {
                Vector3 right = worldPiece.rightAnchor.position;
                Vector3 left = worldPiece.leftAnchor.position;

                List<float> nums = new List<float>();
                nums.Insert(0, 100);
                nums.Insert(Random.Range(0, nums.Count), 50);
                nums.Insert(Random.Range(0, nums.Count), 10);

                if (Random.Range(0, 100) <= nums[0])
                {
                    Debug.Log(nums[0]);
                    Vector3 fireLocation1 = new Vector3(Random.Range(left.x, left.x + 4.5f), left.y + 0.91f, 0f);
                    Instantiate(fire, fireLocation1, Quaternion.identity);
                }
                if (Random.Range(0, 100) <= nums[1])
                {
                    Debug.Log(nums[1]);
                    Vector3 fireLocation2 = new Vector3(Random.Range(left.x + 7.5f, left.x + 11.5f), left.y + 0.91f, 0f);
                    Instantiate(fire, fireLocation2, Quaternion.identity);
                }
                if (Random.Range(0, 100) <= nums[2])
                {
                    Debug.Log(nums[2]);
                    Vector3 fireLocation3 = new Vector3(Random.Range(left.x + 14.5f, right.x), left.y + 0.91f, 0f);
                    Instantiate(fire, fireLocation3, Quaternion.identity);
                }
            }

            if (worldPiece.name == "ground_8(Clone)")
            {
                Vector3 right = worldPiece.rightAnchor.position;
                Vector3 left = worldPiece.leftAnchor.position;

                List<float> nums = new List<float>();
                nums.Insert(0, 100);
                nums.Insert(Random.Range(0, nums.Count), 50);
                nums.Insert(Random.Range(0, nums.Count), 15);
                nums.Insert(Random.Range(0, nums.Count), 5);


                if (Random.Range(0, 100) <= nums[0])
                {
                    Debug.Log(nums[0]);
                    Vector3 fireLocation1 = new Vector3(Random.Range(left.x, left.x + 3.5f), left.y + 0.91f, 0f);
                    Instantiate(fire, fireLocation1, Quaternion.identity);
                }

                if (Random.Range(0, 100) <= nums[1])
                {
                    Debug.Log(nums[1]);
                    Vector3 fireLocation2 = new Vector3(Random.Range(left.x + 6.5f, left.x + 10.5f), left.y + 0.91f, 0f);
                    Instantiate(fire, fireLocation2, Quaternion.identity);
                }

                if (Random.Range(0, 100) <= nums[2])
                {
                    Debug.Log(nums[2]);
                    Vector3 fireLocation3 = new Vector3(Random.Range(left.x + 13.5f, left.x + 17.5f), left.y + 0.91f, 0f);
                    Instantiate(fire, fireLocation3, Quaternion.identity);
                }
                if (Random.Range(0, 100) <= nums[3])
                {
                    Debug.Log(nums[3]);
                    Vector3 fireLocation4 = new Vector3(Random.Range(left.x + 20.5f, right.x), left.y + 0.91f, 0f);
                    Instantiate(fire, fireLocation4, Quaternion.identity);
                }
            }
        }

    }
}
