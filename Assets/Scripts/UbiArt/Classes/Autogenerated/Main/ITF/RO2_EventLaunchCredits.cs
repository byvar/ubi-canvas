using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_EventLaunchCredits : Event {
		[Serialize("onlyPrefetch")] public bool onlyPrefetch;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(onlyPrefetch));
		}
		public override uint? ClassCRC => 0x376C63C3;
	}
}

