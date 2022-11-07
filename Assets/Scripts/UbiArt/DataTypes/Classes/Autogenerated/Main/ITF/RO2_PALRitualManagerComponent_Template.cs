namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_PALRitualManagerComponent_Template : ActorComponent_Template {
		public StringID sequenceAnimation;
		public StringID animVictoryPlayer;
		public StringID animStandPlayer;
		public float victoryTime;
		public CListO<StringID> podiumBoneList;
		public StringID podiumBoneTeensie;
		public StringID cameraFX;
		public Vec3d murphyOnGroundOffset;
		public Vec3d murphyInAirOffset;
		public Vec3d cameraOffset;
		public Vec3d cameraOffsetInAir;
		public float cameraBlend;
		public float maxPlayerSpeed;
		public Generic<Event> musicEvent;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			sequenceAnimation = s.SerializeObject<StringID>(sequenceAnimation, name: "sequenceAnimation");
			animVictoryPlayer = s.SerializeObject<StringID>(animVictoryPlayer, name: "animVictoryPlayer");
			animStandPlayer = s.SerializeObject<StringID>(animStandPlayer, name: "animStandPlayer");
			victoryTime = s.Serialize<float>(victoryTime, name: "victoryTime");
			podiumBoneList = s.SerializeObject<CListO<StringID>>(podiumBoneList, name: "podiumBoneList");
			podiumBoneTeensie = s.SerializeObject<StringID>(podiumBoneTeensie, name: "podiumBoneTeensie");
			cameraFX = s.SerializeObject<StringID>(cameraFX, name: "cameraFX");
			murphyOnGroundOffset = s.SerializeObject<Vec3d>(murphyOnGroundOffset, name: "murphyOnGroundOffset");
			murphyInAirOffset = s.SerializeObject<Vec3d>(murphyInAirOffset, name: "murphyInAirOffset");
			cameraOffset = s.SerializeObject<Vec3d>(cameraOffset, name: "cameraOffset");
			cameraOffsetInAir = s.SerializeObject<Vec3d>(cameraOffsetInAir, name: "cameraOffsetInAir");
			cameraBlend = s.Serialize<float>(cameraBlend, name: "cameraBlend");
			maxPlayerSpeed = s.Serialize<float>(maxPlayerSpeed, name: "maxPlayerSpeed");
			musicEvent = s.SerializeObject<Generic<Event>>(musicEvent, name: "musicEvent");
		}
		public override uint? ClassCRC => 0xFB944847;
	}
}

