using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BossLuchadoreHandComponent_Template : GraphicComponent_Template {
		[Serialize("faction")] public uint faction;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(faction));
		}
		public override uint? ClassCRC => 0xA7166264;
	}
}

