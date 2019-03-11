using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_FireflyCloudComponent : ActorComponent {
		[Serialize("isActivated")] public bool isActivated;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(isActivated));
			}
		}
		public override uint? ClassCRC => 0xF6DA8761;
	}
}

