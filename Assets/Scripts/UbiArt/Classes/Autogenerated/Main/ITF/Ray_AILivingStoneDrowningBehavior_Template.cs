using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AILivingStoneDrowningBehavior_Template : Ray_AIWaterBaseBehavior_Template {
		[Serialize("dive" )] public Placeholder dive;
		[Serialize("drown")] public Placeholder drown;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(dive));
			SerializeField(s, nameof(drown));
		}
		public override uint? ClassCRC => 0x0D67DFC6;
	}
}

