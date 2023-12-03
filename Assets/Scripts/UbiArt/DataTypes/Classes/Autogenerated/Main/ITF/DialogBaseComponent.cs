namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class DialogBaseComponent : ActorComponent {
		public bool playOnce = true;
		public bool loop;
		public float wordTime_Default = 0.05f;
		public float wordTime_Accel = 0.001f;
		public float endTime_Default = 1f;
		public float endTime_Accel = 0.5f;
		public bool waitInit;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				playOnce = s.Serialize<bool>(playOnce, name: "playOnce");
				loop = s.Serialize<bool>(loop, name: "loop");
				wordTime_Default = s.Serialize<float>(wordTime_Default, name: "wordTime_Default");
				wordTime_Accel = s.Serialize<float>(wordTime_Accel, name: "wordTime_Accel");
				endTime_Default = s.Serialize<float>(endTime_Default, name: "endTime_Default");
				endTime_Accel = s.Serialize<float>(endTime_Accel, name: "endTime_Accel");
				waitInit = s.Serialize<bool>(waitInit, name: "waitInit");
			}
		}
		public override uint? ClassCRC => 0x3652B80A;
	}
}

