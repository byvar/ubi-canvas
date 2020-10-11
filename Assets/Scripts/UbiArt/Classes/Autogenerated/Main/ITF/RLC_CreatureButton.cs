using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class RLC_CreatureButton : CSerializable {
		public Placeholder GardenCreature;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			GardenCreature = s.SerializeObject<Placeholder>(GardenCreature, name: "GardenCreature");
		}
		public override uint? ClassCRC => 0x22E29A11;
	}
}

