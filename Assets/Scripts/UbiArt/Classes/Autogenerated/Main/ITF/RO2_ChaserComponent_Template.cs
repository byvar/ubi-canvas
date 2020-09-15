using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_ChaserComponent_Template : ActorComponent_Template {
		public StringID waitAnim;
		public StringID runAnim;
		public StringID jumpAnim;
		public StringID digAnim;
		public StringID dieAnim;
		public Generic<PhysShape> shape;
		public uint faction;
		public uint minFramesDigging;
		public bool useKillingOffset;
		public float killingOffset;
		public float killingOffsetRadius;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			waitAnim = s.SerializeObject<StringID>(waitAnim, name: "waitAnim");
			runAnim = s.SerializeObject<StringID>(runAnim, name: "runAnim");
			jumpAnim = s.SerializeObject<StringID>(jumpAnim, name: "jumpAnim");
			digAnim = s.SerializeObject<StringID>(digAnim, name: "digAnim");
			dieAnim = s.SerializeObject<StringID>(dieAnim, name: "dieAnim");
			shape = s.SerializeObject<Generic<PhysShape>>(shape, name: "shape");
			faction = s.Serialize<uint>(faction, name: "faction");
			minFramesDigging = s.Serialize<uint>(minFramesDigging, name: "minFramesDigging");
			useKillingOffset = s.Serialize<bool>(useKillingOffset, name: "useKillingOffset");
			killingOffset = s.Serialize<float>(killingOffset, name: "killingOffset");
			killingOffsetRadius = s.Serialize<float>(killingOffsetRadius, name: "killingOffsetRadius");
		}
		public override uint? ClassCRC => 0x187901B1;
	}
}

