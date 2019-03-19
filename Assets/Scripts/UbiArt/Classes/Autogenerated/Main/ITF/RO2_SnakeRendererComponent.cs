using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_SnakeRendererComponent : GraphicComponent {
		[Serialize("alignOnTrajectoryOnStart")] public bool alignOnTrajectoryOnStart;
		[Serialize("flipWithDirection"       )] public bool flipWithDirection;
		[Serialize("disablePolyline"         )] public bool disablePolyline;
		[Serialize("disableTopPolyline"      )] public bool disableTopPolyline;
		[Serialize("disableBottomPolyline"   )] public bool disableBottomPolyline;
		[Serialize("flipWithDirection"       )] public byte flipWithDirection;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(alignOnTrajectoryOnStart), boolAsByte: true);
					SerializeField(s, nameof(flipWithDirection));
				}
				SerializeField(s, nameof(flipWithDirection));
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(alignOnTrajectoryOnStart));
					SerializeField(s, nameof(flipWithDirection));
					SerializeField(s, nameof(disablePolyline));
					SerializeField(s, nameof(disableTopPolyline));
					SerializeField(s, nameof(disableBottomPolyline));
				}
			}
		}
		public override uint? ClassCRC => 0xC5B35E73;
	}
}

