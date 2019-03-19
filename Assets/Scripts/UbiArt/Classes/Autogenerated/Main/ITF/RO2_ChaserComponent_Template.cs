using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_ChaserComponent_Template : ActorComponent_Template {
		[Serialize("waitAnim"           )] public StringID waitAnim;
		[Serialize("runAnim"            )] public StringID runAnim;
		[Serialize("jumpAnim"           )] public StringID jumpAnim;
		[Serialize("digAnim"            )] public StringID digAnim;
		[Serialize("dieAnim"            )] public StringID dieAnim;
		[Serialize("shape"              )] public Generic<PhysShape> shape;
		[Serialize("faction"            )] public uint faction;
		[Serialize("minFramesDigging"   )] public uint minFramesDigging;
		[Serialize("useKillingOffset"   )] public bool useKillingOffset;
		[Serialize("killingOffset"      )] public float killingOffset;
		[Serialize("killingOffsetRadius")] public float killingOffsetRadius;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(waitAnim));
			SerializeField(s, nameof(runAnim));
			SerializeField(s, nameof(jumpAnim));
			SerializeField(s, nameof(digAnim));
			SerializeField(s, nameof(dieAnim));
			SerializeField(s, nameof(shape));
			SerializeField(s, nameof(faction));
			SerializeField(s, nameof(minFramesDigging));
			SerializeField(s, nameof(useKillingOffset));
			SerializeField(s, nameof(killingOffset));
			SerializeField(s, nameof(killingOffsetRadius));
		}
		public override uint? ClassCRC => 0x187901B1;
	}
}

