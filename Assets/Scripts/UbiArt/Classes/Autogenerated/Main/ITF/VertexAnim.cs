using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RL)]
	public partial class VertexAnim : CSerializable {
		[Serialize("animGlobalSpeed"   )] public float animGlobalSpeed;
		[Serialize("animGlobalRotSpeed")] public Angle animGlobalRotSpeed;
		[Serialize("animSpeedX"        )] public float animSpeedX;
		[Serialize("animSpeedY"        )] public float animSpeedY;
		[Serialize("animSyncX"         )] public float animSyncX;
		[Serialize("animSyncY"         )] public float animSyncY;
		[Serialize("animAmplitudeX"    )] public float animAmplitudeX;
		[Serialize("animAmplitudeY"    )] public float animAmplitudeY;
		[Serialize("animSync"          )] public float animSync;
		[Serialize("animAngleUsed"     )] public bool animAngleUsed;
		[Serialize("animAngle"         )] public Angle animAngle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(animGlobalSpeed));
			SerializeField(s, nameof(animGlobalRotSpeed));
			SerializeField(s, nameof(animSpeedX));
			SerializeField(s, nameof(animSpeedY));
			SerializeField(s, nameof(animSyncX));
			SerializeField(s, nameof(animSyncY));
			SerializeField(s, nameof(animAmplitudeX));
			SerializeField(s, nameof(animAmplitudeY));
			SerializeField(s, nameof(animSync));
			if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(animAngleUsed), boolAsByte: true);
			} else {
				SerializeField(s, nameof(animAngleUsed));
			}
			SerializeField(s, nameof(animAngle));
		}
	}
}

