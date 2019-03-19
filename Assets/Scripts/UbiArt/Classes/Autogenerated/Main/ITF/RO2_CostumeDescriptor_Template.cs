using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_CostumeDescriptor_Template : TemplateObj {
		[Serialize("decorationBrickPath")] public Path decorationBrickPath;
		[Serialize("priority"           )] public int priority;
		[Serialize("costumeTag"         )] public StringID costumeTag;
		[Serialize("costumetype"        )] public CostumeType costumetype;
		[Serialize("unlockable"         )] public bool unlockable;
		[Serialize("costumetype"        )] public Enum_costumetype costumetype;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(decorationBrickPath));
				SerializeField(s, nameof(priority));
				SerializeField(s, nameof(costumeTag));
				SerializeField(s, nameof(costumetype));
				SerializeField(s, nameof(unlockable));
			} else {
				SerializeField(s, nameof(decorationBrickPath));
				SerializeField(s, nameof(priority));
				SerializeField(s, nameof(costumeTag));
				SerializeField(s, nameof(costumetype));
				SerializeField(s, nameof(unlockable));
			}
		}
		public enum CostumeType {
			[Serialize("CostumeType_Regular"  )] Regular = 0,
			[Serialize("CostumeType_Developer")] Developer = 1,
			[Serialize("CostumeType_Bonus"    )] Bonus = 2,
		}
		public enum Enum_costumetype {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_4")] Value_4 = 4,
		}
		public override uint? ClassCRC => 0x16B08FDA;
	}
}

