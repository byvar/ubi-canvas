using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_LightningPatchAIComponent_Template : ActorComponent_Template {
		public float maxLength;
		public StringID boneName;
		public StringID effectboneName;
		public GFXMaterialSerializable HeadPath;
		public GFXMaterialSerializable BodyPath;
		public GFXMaterialSerializable TailPath;
		public uint headMaxIndices;
		public uint tailMaxIndices;
		public uint bodyMaxIndices;
		public uint headLoopStart;
		public uint headLoopStop;
		public uint tailLoopStart;
		public uint tailLoopStop;
		public uint bodyLoopStart;
		public uint bodyLoopStop;
		public Vec2d headSize;
		public Vec2d tailSize;
		public float speed;
		public Vec2d headCenter;
		public Vec2d tailCenter;
		public BezierCurveRenderer_Template renderer;
		public float playRate;
		public float headZOffset;
		public float tailZOffset;
		public float bodyZOffset;
		public StringID ChargeFx;
		public StringID LoopFx;
		public StringID EndFx;
		public float stimWidth;
		public bool useAnimInfo;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			maxLength = s.Serialize<float>(maxLength, name: "maxLength");
			boneName = s.SerializeObject<StringID>(boneName, name: "boneName");
			effectboneName = s.SerializeObject<StringID>(effectboneName, name: "effectboneName");
			HeadPath = s.SerializeObject<GFXMaterialSerializable>(HeadPath, name: "HeadPath");
			BodyPath = s.SerializeObject<GFXMaterialSerializable>(BodyPath, name: "BodyPath");
			TailPath = s.SerializeObject<GFXMaterialSerializable>(TailPath, name: "TailPath");
			headMaxIndices = s.Serialize<uint>(headMaxIndices, name: "headMaxIndices");
			tailMaxIndices = s.Serialize<uint>(tailMaxIndices, name: "tailMaxIndices");
			bodyMaxIndices = s.Serialize<uint>(bodyMaxIndices, name: "bodyMaxIndices");
			headLoopStart = s.Serialize<uint>(headLoopStart, name: "headLoopStart");
			headLoopStop = s.Serialize<uint>(headLoopStop, name: "headLoopStop");
			tailLoopStart = s.Serialize<uint>(tailLoopStart, name: "tailLoopStart");
			tailLoopStop = s.Serialize<uint>(tailLoopStop, name: "tailLoopStop");
			bodyLoopStart = s.Serialize<uint>(bodyLoopStart, name: "bodyLoopStart");
			bodyLoopStop = s.Serialize<uint>(bodyLoopStop, name: "bodyLoopStop");
			headSize = s.SerializeObject<Vec2d>(headSize, name: "headSize");
			tailSize = s.SerializeObject<Vec2d>(tailSize, name: "tailSize");
			speed = s.Serialize<float>(speed, name: "speed");
			headCenter = s.SerializeObject<Vec2d>(headCenter, name: "headCenter");
			tailCenter = s.SerializeObject<Vec2d>(tailCenter, name: "tailCenter");
			renderer = s.SerializeObject<BezierCurveRenderer_Template>(renderer, name: "renderer");
			playRate = s.Serialize<float>(playRate, name: "playRate");
			headZOffset = s.Serialize<float>(headZOffset, name: "headZOffset");
			tailZOffset = s.Serialize<float>(tailZOffset, name: "tailZOffset");
			bodyZOffset = s.Serialize<float>(bodyZOffset, name: "bodyZOffset");
			ChargeFx = s.SerializeObject<StringID>(ChargeFx, name: "ChargeFx");
			LoopFx = s.SerializeObject<StringID>(LoopFx, name: "LoopFx");
			EndFx = s.SerializeObject<StringID>(EndFx, name: "EndFx");
			stimWidth = s.Serialize<float>(stimWidth, name: "stimWidth");
			useAnimInfo = s.Serialize<bool>(useAnimInfo, name: "useAnimInfo");
		}
		public override uint? ClassCRC => 0xAF5BE86E;
	}
}

