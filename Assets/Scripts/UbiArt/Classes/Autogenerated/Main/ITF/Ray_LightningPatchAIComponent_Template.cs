using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_LightningPatchAIComponent_Template : CSerializable {
		public float maxLength;
		public StringID boneName;
		public StringID effectboneName;
		public Path HeadPath;
		public Path BodyPath;
		public Path TailPath;
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
		public Placeholder renderer;
		public float playRate;
		public float headZOffset;
		public float tailZOffset;
		public float bodyZOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			maxLength = s.Serialize<float>(maxLength, name: "maxLength");
			boneName = s.SerializeObject<StringID>(boneName, name: "boneName");
			effectboneName = s.SerializeObject<StringID>(effectboneName, name: "effectboneName");
			HeadPath = s.SerializeObject<Path>(HeadPath, name: "HeadPath");
			BodyPath = s.SerializeObject<Path>(BodyPath, name: "BodyPath");
			TailPath = s.SerializeObject<Path>(TailPath, name: "TailPath");
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
			renderer = s.SerializeObject<Placeholder>(renderer, name: "renderer");
			playRate = s.Serialize<float>(playRate, name: "playRate");
			headZOffset = s.Serialize<float>(headZOffset, name: "headZOffset");
			tailZOffset = s.Serialize<float>(tailZOffset, name: "tailZOffset");
			bodyZOffset = s.Serialize<float>(bodyZOffset, name: "bodyZOffset");
		}
		public override uint? ClassCRC => 0x120B97F1;
	}
}

