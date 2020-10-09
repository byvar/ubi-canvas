using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.VH | GameFlags.RA)]
	public partial class FxData : CSerializable {
		public StringID fxFall;
		public StringID fxHit;
		public StringID fxSteam;
		public StringID soundFall;
		public StringID soundHit;
		public StringID soundDestroy;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			fxFall = s.SerializeObject<StringID>(fxFall, name: "fxFall");
			fxHit = s.SerializeObject<StringID>(fxHit, name: "fxHit");
			fxSteam = s.SerializeObject<StringID>(fxSteam, name: "fxSteam");
			soundFall = s.SerializeObject<StringID>(soundFall, name: "soundFall");
			soundHit = s.SerializeObject<StringID>(soundHit, name: "soundHit");
			soundDestroy = s.SerializeObject<StringID>(soundDestroy, name: "soundDestroy");
		}
	}
}

