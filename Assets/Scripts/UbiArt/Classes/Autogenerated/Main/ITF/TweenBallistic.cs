using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.VH | GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class TweenBallistic : TweenTranslation {
		[Serialize("movement"    )] public Vector3 movement;
		[Serialize("startTangent")] public Vector3 startTangent;
		[Serialize("name"        )] public StringID name;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO || Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(movement));
				SerializeField(s, nameof(startTangent));
			} else {
				SerializeField(s, nameof(movement));
				SerializeField(s, nameof(startTangent));
			}
		}
		public override uint? ClassCRC => 0x61D21A33;
	}
}

