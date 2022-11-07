namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AILightningAction_Template : AIAction_Template {
		public StringID startBoneName;
		public StringID destBoneName;
		public float defaultSize;
		public Angle angleOffset;
		public uint hitLevel;
		public uint hitType;
		public int useStartStim;
		public int useDestStim;
		public float startStimRadius;
		public float destStimRadius;
		public Vec2d startStimOffset;
		public Vec2d destStimOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			startBoneName = s.SerializeObject<StringID>(startBoneName, name: "startBoneName");
			destBoneName = s.SerializeObject<StringID>(destBoneName, name: "destBoneName");
			defaultSize = s.Serialize<float>(defaultSize, name: "defaultSize");
			angleOffset = s.SerializeObject<Angle>(angleOffset, name: "angleOffset");
			hitLevel = s.Serialize<uint>(hitLevel, name: "hitLevel");
			hitType = s.Serialize<uint>(hitType, name: "hitType");
			useStartStim = s.Serialize<int>(useStartStim, name: "useStartStim");
			useDestStim = s.Serialize<int>(useDestStim, name: "useDestStim");
			startStimRadius = s.Serialize<float>(startStimRadius, name: "startStimRadius");
			destStimRadius = s.Serialize<float>(destStimRadius, name: "destStimRadius");
			startStimOffset = s.SerializeObject<Vec2d>(startStimOffset, name: "startStimOffset");
			destStimOffset = s.SerializeObject<Vec2d>(destStimOffset, name: "destStimOffset");
		}
		public override uint? ClassCRC => 0x120A844F;
	}
}

