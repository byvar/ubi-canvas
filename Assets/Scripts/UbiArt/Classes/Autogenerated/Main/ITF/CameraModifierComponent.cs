using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class CameraModifierComponent : ActorComponent {
		[Serialize("cameraView"            )] public uint cameraView;
		[Serialize("ignoreAABB"            )] public bool ignoreAABB;
		[Serialize("ignoreSceneActiveState")] public bool ignoreSceneActiveState;
		[Serialize("CM"                    )] public CamModifier CM;
		[Serialize("localAABB"             )] public AABB localAABB;
		[Serialize("CM_override"           )] public CamModifierOverride CM_override;
		[Serialize("zTolerance"            )] public float zTolerance;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(CM));
					SerializeField(s, nameof(CM_override));
				}
			} else if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.VH) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(cameraView));
					SerializeField(s, nameof(ignoreAABB));
					SerializeField(s, nameof(CM));
				}
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(localAABB));
				}
			} else if (Settings.s.game == Settings.Game.COL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(cameraView));
					SerializeField(s, nameof(ignoreAABB), boolAsByte: true);
					SerializeField(s, nameof(zTolerance));
				}
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(localAABB));
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(cameraView));
					SerializeField(s, nameof(ignoreAABB));
					SerializeField(s, nameof(ignoreSceneActiveState));
					SerializeField(s, nameof(CM));
				}
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(localAABB));
				}
			}
		}
		public override uint? ClassCRC => 0x6C8DD66E;
	}
}

