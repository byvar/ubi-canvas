namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_SnakeRendererComponent_Template : GraphicComponent_Template {
		public CArrayO<Generic<RO2_SnakeBodyPart_Template>> bodyParts;
		public float bodyPartsZSpacing = 0.002f;
		public bool drawHeadBelow;
		public bool broadcastEventToPart = true;
		public float trajectoryOffset;
		public float sampleLength = 0.1f;
		public Path gameMaterial;
		public bool usePolylinePhantom;
		public GFXMaterialSerializable gfxMaterial;
		public Path amvPath;
		public StringID fxStart = new StringID(0x873ef53c);
		public StringID fxLoop = new StringID(0x71c6b3da);
		public StringID fxStop = new StringID(0x43ffe1ae);
		public StringID inputSpeed = new StringID(0xfb6e8b46);
		public RO2_SnakeRendererComponent_Template.Perturbator tapPerturbator;
		public CListO<RO2_SnakeRendererComponent_Template.Perturbator> hitPerturbators;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			bodyParts = s.SerializeObject<CArrayO<Generic<RO2_SnakeBodyPart_Template>>>(bodyParts, name: "bodyParts");
			bodyPartsZSpacing = s.Serialize<float>(bodyPartsZSpacing, name: "bodyPartsZSpacing");
			drawHeadBelow = s.Serialize<bool>(drawHeadBelow, name: "drawHeadBelow");
			broadcastEventToPart = s.Serialize<bool>(broadcastEventToPart, name: "broadcastEventToPart");
			trajectoryOffset = s.Serialize<float>(trajectoryOffset, name: "trajectoryOffset");
			sampleLength = s.Serialize<float>(sampleLength, name: "sampleLength");
			gameMaterial = s.SerializeObject<Path>(gameMaterial, name: "gameMaterial");
			usePolylinePhantom = s.Serialize<bool>(usePolylinePhantom, name: "usePolylinePhantom");
			gfxMaterial = s.SerializeObject<GFXMaterialSerializable>(gfxMaterial, name: "gfxMaterial");
			amvPath = s.SerializeObject<Path>(amvPath, name: "amvPath");
			fxStart = s.SerializeObject<StringID>(fxStart, name: "fxStart");
			fxLoop = s.SerializeObject<StringID>(fxLoop, name: "fxLoop");
			fxStop = s.SerializeObject<StringID>(fxStop, name: "fxStop");
			inputSpeed = s.SerializeObject<StringID>(inputSpeed, name: "inputSpeed");
			tapPerturbator = s.SerializeObject<RO2_SnakeRendererComponent_Template.Perturbator>(tapPerturbator, name: "tapPerturbator");
			hitPerturbators = s.SerializeObject<CListO<RO2_SnakeRendererComponent_Template.Perturbator>>(hitPerturbators, name: "hitPerturbators");
		}
		[Games(GameFlags.RA)]
		public partial class Perturbator : CSerializable {
			public uint range = 1;
			public float duration = 1f;
			public float amplitude = 1f;
			public float frequency = 1f;
			public StringID fx;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				range = s.Serialize<uint>(range, name: "range");
				duration = s.Serialize<float>(duration, name: "duration");
				amplitude = s.Serialize<float>(amplitude, name: "amplitude");
				frequency = s.Serialize<float>(frequency, name: "frequency");
				fx = s.SerializeObject<StringID>(fx, name: "fx");
			}
		}
		public override uint? ClassCRC => 0x4E721589;
	}
}

