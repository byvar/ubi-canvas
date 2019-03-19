using UnityEngine;

namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class userProfileShortData : CSerializable {
		[Serialize("pid"          )] public string pid;
		[Serialize("name"         )] public string name;
		[Serialize("deviceCountry")] public string deviceCountry;
		[Serialize("stars"        )] public uint stars;
		[Serialize("costume"      )] public StringID costume;
		[Serialize("img"          )] public string img;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(pid));
			SerializeField(s, nameof(name));
			SerializeField(s, nameof(deviceCountry));
			SerializeField(s, nameof(stars));
			SerializeField(s, nameof(costume));
			SerializeField(s, nameof(img));
		}
		public override uint? ClassCRC => 0x12CC28F5;
	}
}

