using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_SpikyPlatformAIComponent_Template : ActorComponent_Template {
		[Serialize("setDown")] public StringID setDown;
		[Serialize("setUp"  )] public StringID setUp;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(setDown));
			SerializeField(s, nameof(setUp));
		}
		public override uint? ClassCRC => 0x9CB4987E;
	}
}

