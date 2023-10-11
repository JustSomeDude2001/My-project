using System;
using System.Collections.Generic;
using UnityEngine;

namespace World
{
    public abstract class WorldGeneration : MonoBehaviour
    {
        [HideInInspector] public Dictionary<Tuple<int, int>, Transform> Chunks = new Dictionary<Tuple<int, int>, Transform>();

        public Vector2 chunkDimensions;

        public Vector3 ChunkToWorld(Tuple<int, int> chunk)
        {
            return new Vector3(chunk.Item1 * chunkDimensions.x, 0, chunk.Item2 * chunkDimensions.y);
        }

        public Tuple<int, int> WorldToChunk(Vector3 position)
        {
            int x = (int) (position.x / chunkDimensions.x);
            int y = (int) (position.z / chunkDimensions.y);
        
            return new Tuple<int, int>(x, y);
        }

        public bool HasChunk(Tuple<int, int> chunk)
        {
            return Chunks.ContainsKey(chunk);
        }

        public void AddChunk(Tuple<int, int> chunk, GameObject chunkObject)
        {
            if (!HasChunk(chunk))
            {
                GameObject newChunk = Instantiate(chunkObject, ChunkToWorld(chunk), Quaternion.identity);
                Chunks.Add(chunk, newChunk.transform);
                Debug.Log("Generated chunk " + chunk + " successfully");
            }
            else
            {
                Debug.Log("Failed to add chunk " + chunk + ", as it is already present");
            }
        }

        public void RemoveChunk(Tuple<int, int> chunk)
        {
            if (!HasChunk(chunk))
            {
                Debug.Log("Failed to delete chunk " + chunk);
            }
            else
            {
                Transform target;
                Chunks.Remove(chunk, out target);
                Destroy(target.gameObject);
                Debug.Log("Successfully removed chunk" + chunk);
            }
        }
    }
}
