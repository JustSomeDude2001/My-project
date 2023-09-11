using System;
using UnityEngine;

namespace World
{
    public class DefaultWorldGeneration : WorldGeneration
    {
        public Transform player;
        public GameObject baseChunk;

        public int generationRadius;

        private void Update()
        {
            var playerChunk = WorldToChunk(player.position);

            for (int i = -generationRadius; i <= generationRadius; i++)
            {
                for (int j = -generationRadius; j <= generationRadius; j++)
                {
                    var newChunk = new Tuple<int, int>(playerChunk.Item1 + i, playerChunk.Item2 + j);
                    if (!HasChunk(newChunk))
                    {
                        AddChunk(newChunk, baseChunk);
                    }
                }
            } 
        }
    }
}
