using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_TouchControllerComponent_Template : ActorComponent_Template {
		[Serialize("shape"         )] public Generic<PhysShape> shape;
		[Serialize("fxControlStart")] public StringID fxControlStart;
		[Serialize("fxControlStop" )] public StringID fxControlStop;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(shape));
			SerializeField(s, nameof(fxControlStart));
			SerializeField(s, nameof(fxControlStop));
		}
		public override uint? ClassCRC => 0x21121667;
	}
}

