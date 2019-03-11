using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BossShieldComponent : ActorComponent {
		[Serialize("startOn")] public bool startOn;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(startOn));
			}
		}
		public override uint? ClassCRC => 0xD7D7E6DF;
	}
}

