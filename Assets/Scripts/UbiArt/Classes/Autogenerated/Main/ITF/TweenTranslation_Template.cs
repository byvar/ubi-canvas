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
		[Serialize("duration"        )] public float duration;
		[Serialize("name"            )] public StringID name;
		[Serialize("float__0"        )] public float float__0;
		[Serialize("float__1"        )] public float float__1;
		[Serialize("float__2"        )] public float float__2;
		[Serialize("float__3"        )] public float float__3;
		[Serialize("int__4"          )] public int int__4;
		[Serialize("int__5"          )] public int int__5;
		[Serialize("AngleAmount__6"  )] public AngleAmount AngleAmount__6;
		[Serialize("AngleAmount__7"  )] public AngleAmount AngleAmount__7;
		[Serialize("Vector2__8"      )] public Vector2 Vector2__8;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR) {
				SerializeField(s, nameof(float__0));
				SerializeField(s, nameof(float__1));
				SerializeField(s, nameof(float__2));
				SerializeField(s, nameof(float__3));
				SerializeField(s, nameof(int__4));
				SerializeField(s, nameof(int__5));
				SerializeField(s, nameof(AngleAmount__6));
				SerializeField(s, nameof(AngleAmount__7));
				SerializeField(s, nameof(Vector2__8));
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(duration));
				SerializeField(s, nameof(name));
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

