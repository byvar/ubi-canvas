using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RJR | GameFlags.RFR | GameFlags.RL)]
	public partial class TweenTranslation_Template : TweenInstruction_Template {
		[Serialize("startDuration"   )] public float startDuration;
		[Serialize("endDuration"     )] public float endDuration;
		[Serialize("startSpeed"      )] public float startSpeed;
		[Serialize("endSpeed"        )] public float endSpeed;
		[Serialize("rotateTrajectory")] public bool rotateTrajectory;
		[Serialize("rotateActor"     )] public bool rotateActor;
		[Serialize("angle"           )] public AngleAmount angle;
		[Serialize("angleOffset"     )] public AngleAmount angleOffset;
		[Serialize("scaleMultiplier" )] public Vector2 scaleMultiplier;
		[Serialize("speed"           )] public float speed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO || Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR) {
				SerializeField(s, nameof(startDuration));
				SerializeField(s, nameof(endDuration));
				SerializeField(s, nameof(startSpeed));
				SerializeField(s, nameof(endSpeed));
				SerializeField(s, nameof(rotateTrajectory));
				SerializeField(s, nameof(rotateActor));
				SerializeField(s, nameof(angle));
				SerializeField(s, nameof(angleOffset));
				SerializeField(s, nameof(scaleMultiplier));
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(startDuration));
				SerializeField(s, nameof(endDuration));
				SerializeField(s, nameof(startSpeed));
				SerializeField(s, nameof(endSpeed));
				SerializeField(s, nameof(rotateTrajectory), boolAsByte: true);
				SerializeField(s, nameof(rotateActor), boolAsByte: true);
				SerializeField(s, nameof(angle));
				SerializeField(s, nameof(angleOffset));
				SerializeField(s, nameof(scaleMultiplier));
				SerializeField(s, nameof(speed));
			} else {
				SerializeField(s, nameof(startDuration));
				SerializeField(s, nameof(endDuration));
				SerializeField(s, nameof(startSpeed));
				SerializeField(s, nameof(endSpeed));
				SerializeField(s, nameof(rotateTrajectory));
				SerializeField(s, nameof(rotateActor));
				SerializeField(s, nameof(angle));
				SerializeField(s, nameof(angleOffset));
				SerializeField(s, nameof(scaleMultiplier));
				SerializeField(s, nameof(speed));
			}
		}
		public override uint? ClassCRC => 0x889B12E1;
	}
}

