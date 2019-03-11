using UnityEngine;

namespace UbiArt.ITF {
	public partial class FriezeContactDetectorComponent_Template : DetectorComponent_Template {
		[Serialize("factionToDetect")] public uint factionToDetect;
		[Serialize("allowDeadActors")] public bool allowDeadActors;
		[Serialize("detectHang"     )] public bool detectHang;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(factionToDetect));
			SerializeField(s, nameof(allowDeadActors));
			SerializeField(s, nameof(detectHang));
		}
		public override uint? ClassCRC => 0xF0860387;
	}
}

