using System;
using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_CostumeDescriptor_Template : TemplateObj {
		[Serialize("decorationBrickPath")] public Path decorationBrickPath;
		[Serialize("priority"           )] public int priority;
		[Serialize("costumeTag"         )] public StringID costumeTag;
		[Serialize("costumetype"        )] public CostumeType costumetype;
		[Serialize("costumetype"        )] public CostumeType2 costumetype2;
		[Serialize("unlockable"         )] public bool unlockable;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(decorationBrickPath));
				SerializeField(s, nameof(priority));
				SerializeField(s, nameof(costumeTag));
				SerializeField(s, nameof(costumetype2));
				SerializeField(s, nameof(unlockable));
			} else {
				SerializeField(s, nameof(decorationBrickPath));
				SerializeField(s, nameof(priority));
				SerializeField(s, nameof(costumeTag));
				SerializeField(s, nameof(costumetype));
				SerializeField(s, nameof(unlockable));
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

