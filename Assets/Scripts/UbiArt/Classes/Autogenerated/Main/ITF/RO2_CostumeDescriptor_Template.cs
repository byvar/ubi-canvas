using System;
using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_CostumeDescriptor_Template : TemplateObj {
		public Path decorationBrickPath;
		public int priority;
		public StringID costumeTag;
		public CostumeType costumetype;
		public CostumeType2 costumetype2;
		public bool unlockable;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				decorationBrickPath = s.SerializeObject<Path>(decorationBrickPath, name: "decorationBrickPath");
				priority = s.Serialize<int>(priority, name: "priority");
				costumeTag = s.SerializeObject<StringID>(costumeTag, name: "costumeTag");
				costumetype2 = s.Serialize<CostumeType2>(costumetype2, name: "costumetype");
				unlockable = s.Serialize<bool>(unlockable, name: "unlockable");
			} else {
				decorationBrickPath = s.SerializeObject<Path>(decorationBrickPath, name: "decorationBrickPath");
				priority = s.Serialize<int>(priority, name: "priority");
				costumeTag = s.SerializeObject<StringID>(costumeTag, name: "costumeTag");
				costumetype = s.Serialize<CostumeType>(costumetype, name: "costumetype");
				unlockable = s.Serialize<bool>(unlockable, name: "unlockable");
			}
		}
		[Flags]
		public enum CostumeType {
			[Serialize("CostumeType_Regular"  )] Regular = 0,
			[Serialize("CostumeType_Developer")] Developer = 1,
			[Serialize("CostumeType_Bonus"    )] Bonus = 2,
		}
		[Flags]
		public enum CostumeType2 {
			[Serialize("CostumeType_Regular"  )] Regular = 0,
			[Serialize("CostumeType_Developer")] Developer = 1,
			[Serialize("CostumeType_Bonus"    )] Bonus = 2,
			[Serialize("Value_4")] Value_4 = 4,
		}
		public override uint? ClassCRC => 0x16B08FDA;
	}
}

