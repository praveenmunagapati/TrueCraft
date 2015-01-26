using System;
using TrueCraft.API.Logic;
using TrueCraft.API;

namespace TrueCraft.Core.Logic.Items
{
    public class DiamondShovelItem : ShovelItem
    {
        public static readonly short ItemID = 0x115;

        public override short ID { get { return 0x115; } }

        public override ToolMaterial Material { get { return ToolMaterial.Diamond; } }

        public override short BaseDurability { get { return 1562; } }

        public override string DisplayName { get { return "Diamond Shovel"; } }
    }
}