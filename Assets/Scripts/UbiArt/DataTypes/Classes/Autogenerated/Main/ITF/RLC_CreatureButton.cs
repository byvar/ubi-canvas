using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class RLC_CreatureButton : RLC_BasicButton {
		public RLC_GardenCreature GardenCreature;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			GardenCreature = s.SerializeObject<RLC_GardenCreature>(GardenCreature, name: "GardenCreature");
		}
		public override uint? ClassCRC => 0x22E29A11;
	}
}

