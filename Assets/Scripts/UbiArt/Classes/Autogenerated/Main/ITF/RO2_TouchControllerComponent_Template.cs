using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_TouchControllerComponent_Template : ActorComponent_Template {
		public Generic<PhysShape> shape;
		public StringID fxControlStart;
		public StringID fxControlStop;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			shape = s.SerializeObject<Generic<PhysShape>>(shape, name: "shape");
			fxControlStart = s.SerializeObject<StringID>(fxControlStart, name: "fxControlStart");
			fxControlStop = s.SerializeObject<StringID>(fxControlStop, name: "fxControlStop");
		}
		public override uint? ClassCRC => 0x21121667;
	}
}

