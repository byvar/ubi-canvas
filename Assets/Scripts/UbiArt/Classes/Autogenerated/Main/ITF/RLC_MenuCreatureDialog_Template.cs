using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_MenuCreatureDialog_Template : UIMenuBasic_Template {
		[Serialize("SlowDTCurve")] public Spline SlowDTCurve;
		[Serialize("Gem3DPath"  )] public Path Gem3DPath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(SlowDTCurve));
			SerializeField(s, nameof(Gem3DPath));
		}
		public override uint? ClassCRC => 0x3F805329;
	}
}

