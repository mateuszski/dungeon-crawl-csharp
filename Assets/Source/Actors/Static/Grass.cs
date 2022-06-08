﻿namespace DungeonCrawl.Actors.Static
{
    public class Grass : Actor
    {
        public override int DefaultSpriteId => 5;
        public override string DefaultName { get; set; } =  "Grass";

        public override bool Detectable => false;
    }
}