using UnityEngine;

namespace UbiArt.ITF {
	public partial class ToggleAnimOnEventComponent : ActorComponent {
		[Serialize("startOpen")] public bool startOpen;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(startOpen));
			}
		}
		public override uint? ClassCRC => 0x40B26DFB;
	}
}

