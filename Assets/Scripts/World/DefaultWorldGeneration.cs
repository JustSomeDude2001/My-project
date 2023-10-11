using System;
using UnityEngine;

namespace World
{
    public class DefaultWorldGeneration : WorldGeneration
    {
        public Transform player;
        public GameObject baseChunk;

        public int generationRadius;
        public int removalRadius;

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

            for (int i = -removalRadius; i <= removalRadius; i++)
            {
                Tuple<int, int>[] newChunks = 
                {
                    Tuple.Create(playerChunk.Item1 + i, playerChunk.Item2 + removalRadius),
                    Tuple.Create(playerChunk.Item1 + removalRadius, playerChunk.Item2 + i),
                    Tuple.Create(playerChunk.Item1 + i, playerChunk.Item2 - removalRadius),
                    Tuple.Create(playerChunk.Item1 - removalRadius, playerChunk.Item2 + i)
                };

                for (int j = 0; j < 4; j++)
                {
                    if (HasChunk(newChunks[j]))
                        RemoveChunk(newChunks[j]);
                }
            }
        }
    }
}
