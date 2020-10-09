using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class RLC_GameGlobalsDeviceCountryCondition : online.GameGlobalsCondition {
		public string country;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			country = s.Serialize<string>(country, name: "country");
		}
		public override uint? ClassCRC => 0x7F0703A3;
	}
}

