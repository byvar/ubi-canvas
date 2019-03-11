using UnityEngine;

namespace UbiArt.ITF {
	public partial class StickToPolylinePhysComponent : PhysComponent {
		[Serialize("ForceVerticalBanking")] public bool ForceVerticalBanking;
		[Serialize("IgnoreAngle"         )] public bool IgnoreAngle;
		[Serialize("StartDisable"        )] public bool StartDisable;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
			} else {
				SerializeField(s, nameof(ForceVerticalBanking));
				SerializeField(s, nameof(IgnoreAngle));
				SerializeField(s, nameof(StartDisable));
			}
		}
		public override uint? ClassCRC => 0xB820D559;
	}
}

