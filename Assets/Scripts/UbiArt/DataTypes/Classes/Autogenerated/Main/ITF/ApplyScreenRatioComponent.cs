using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class ApplyScreenRatioComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x89D68551;
	}
}

