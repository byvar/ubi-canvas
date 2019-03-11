using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_DisplayTutoIconComponent_Template : ActorComponent_Template {
		[Serialize("tutos3d"            )] public SpawnActorPathList tutos3d;
		[Serialize("tutos2d"            )] public SpawnActorPathList tutos2d;
		[Serialize("autoHideCount"      )] public uint autoHideCount;
		[Serialize("animIdle"           )] public StringID animIdle;
		[Serialize("animIdleWithInfo"   )] public StringID animIdleWithInfo;
		[Serialize("idleTime"           )] public float idleTime;
		[Serialize("idleWithInfoNbTimes")] public uint idleWithInfoNbTimes;
		[Serialize("successfulEvent"    )] public Generic<Event> successfulEvent;
		[Serialize("fadeTotalTime"      )] public float fadeTotalTime;
		[Serialize("tutoScale"          )] public Vector2 tutoScale;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(tutos3d));
			SerializeField(s, nameof(tutos2d));
			SerializeField(s, nameof(autoHideCount));
			SerializeField(s, nameof(animIdle));
			SerializeField(s, nameof(animIdleWithInfo));
			SerializeField(s, nameof(idleTime));
			SerializeField(s, nameof(idleWithInfoNbTimes));
			SerializeField(s, nameof(successfulEvent));
			SerializeField(s, nameof(fadeTotalTime));
			SerializeField(s, nameof(tutoScale));
		}
		public override uint? ClassCRC => 0xC26BEEB1;
	}
}

