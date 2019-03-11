using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_PrisonerCageComponent : RO2_AIComponent {
		[Serialize("shape"              )] public EditableShape shape;
		[Serialize("savePosOnCheckpoint")] public bool savePosOnCheckpoint;
		[Serialize("canTriggerMagnet"   )] public bool canTriggerMagnet;
		[Serialize("isBroken"           )] public bool isBroken;
		[Serialize("checkpointAngle"    )] public float checkpointAngle;
		[Serialize("checkpointPos"      )] public Vector2 checkpointPos;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(shape));
					SerializeField(s, nameof(savePosOnCheckpoint));
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(isBroken));
					SerializeField(s, nameof(checkpointAngle));
					SerializeField(s, nameof(checkpointPos));
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(shape));
					SerializeField(s, nameof(savePosOnCheckpoint));
					SerializeField(s, nameof(canTriggerMagnet));
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(isBroken));
					SerializeField(s, nameof(checkpointAngle));
					SerializeField(s, nameof(checkpointPos));
				}
			}
		}
		public override uint? ClassCRC => 0xC509F8EE;
	}
}

