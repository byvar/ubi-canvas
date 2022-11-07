namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_DarkRaymanComponent_Template : ActorComponent_Template {
		public uint frameToWaitBeforeRehit;
		public float waitDurationWhenDead;
		public float nextInfectionTransitionDuration;
		public uint travelAccelType;
		public StringID FXDarkRayman;
		public StringID FXGhostedPlayer;
		public StringID FXVortex;
		public StringID FXOnHit;
		public StringID FXAppear;
		public StringID FXDisappear;
		public StringID FXDisappearAndInfect;
		public StringID FXMock;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			frameToWaitBeforeRehit = s.Serialize<uint>(frameToWaitBeforeRehit, name: "frameToWaitBeforeRehit");
			waitDurationWhenDead = s.Serialize<float>(waitDurationWhenDead, name: "waitDurationWhenDead");
			nextInfectionTransitionDuration = s.Serialize<float>(nextInfectionTransitionDuration, name: "nextInfectionTransitionDuration");
			travelAccelType = s.Serialize<uint>(travelAccelType, name: "travelAccelType");
			FXDarkRayman = s.SerializeObject<StringID>(FXDarkRayman, name: "FXDarkRayman");
			FXGhostedPlayer = s.SerializeObject<StringID>(FXGhostedPlayer, name: "FXGhostedPlayer");
			FXVortex = s.SerializeObject<StringID>(FXVortex, name: "FXVortex");
			FXOnHit = s.SerializeObject<StringID>(FXOnHit, name: "FXOnHit");
			FXAppear = s.SerializeObject<StringID>(FXAppear, name: "FXAppear");
			FXDisappear = s.SerializeObject<StringID>(FXDisappear, name: "FXDisappear");
			FXDisappearAndInfect = s.SerializeObject<StringID>(FXDisappearAndInfect, name: "FXDisappearAndInfect");
			FXMock = s.SerializeObject<StringID>(FXMock, name: "FXMock");
		}
		public override uint? ClassCRC => 0x1DFBB1D1;
	}
}

