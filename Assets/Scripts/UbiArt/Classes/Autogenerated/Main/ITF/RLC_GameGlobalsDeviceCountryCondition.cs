using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_GameGlobalsDeviceCountryCondition : online.GameGlobalsCondition {
		[Serialize("country")] public string country;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(country));
		}
		public override uint? ClassCRC => 0x7F0703A3;
	}
}

