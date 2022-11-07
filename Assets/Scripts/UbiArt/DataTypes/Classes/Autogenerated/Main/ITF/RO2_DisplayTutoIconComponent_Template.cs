namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_DisplayTutoIconComponent_Template : ActorComponent_Template {
		public SpawnActorPathList tutos3d;
		public SpawnActorPathList tutos2d;
		public uint autoHideCount;
		public StringID animIdle;
		public StringID animIdleWithInfo;
		public float idleTime;
		public uint idleWithInfoNbTimes;
		public Generic<Event> successfulEvent;
		public float fadeTotalTime;
		public Vec2d tutoScale;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			tutos3d = s.SerializeObject<SpawnActorPathList>(tutos3d, name: "tutos3d");
			tutos2d = s.SerializeObject<SpawnActorPathList>(tutos2d, name: "tutos2d");
			autoHideCount = s.Serialize<uint>(autoHideCount, name: "autoHideCount");
			animIdle = s.SerializeObject<StringID>(animIdle, name: "animIdle");
			animIdleWithInfo = s.SerializeObject<StringID>(animIdleWithInfo, name: "animIdleWithInfo");
			idleTime = s.Serialize<float>(idleTime, name: "idleTime");
			idleWithInfoNbTimes = s.Serialize<uint>(idleWithInfoNbTimes, name: "idleWithInfoNbTimes");
			successfulEvent = s.SerializeObject<Generic<Event>>(successfulEvent, name: "successfulEvent");
			fadeTotalTime = s.Serialize<float>(fadeTotalTime, name: "fadeTotalTime");
			tutoScale = s.SerializeObject<Vec2d>(tutoScale, name: "tutoScale");
		}
		public override uint? ClassCRC => 0xC26BEEB1;
	}
}

