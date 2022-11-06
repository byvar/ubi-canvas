using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_CarnivorousPlatformComponent_Template : RO2_PlatformAIComponent_Template {
		public float closedDuration;
		public uint hitLevel;
		public StringID mouthOpened;
		public StringID mouthClosed;
		public StringID mouthClosingStart;
		public StringID mouthClosing;
		public StringID mouthOpening;
		public StringID mouthOpeningEnd;
		public StringID mouthBump;
		public StringID mouthHit;
		public uint platformPolylineParameterIndex;
		public uint spikesPolylineParameterIndex;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			closedDuration = s.Serialize<float>(closedDuration, name: "closedDuration");
			hitLevel = s.Serialize<uint>(hitLevel, name: "hitLevel");
			mouthOpened = s.SerializeObject<StringID>(mouthOpened, name: "mouthOpened");
			mouthClosed = s.SerializeObject<StringID>(mouthClosed, name: "mouthClosed");
			mouthClosingStart = s.SerializeObject<StringID>(mouthClosingStart, name: "mouthClosingStart");
			mouthClosing = s.SerializeObject<StringID>(mouthClosing, name: "mouthClosing");
			mouthOpening = s.SerializeObject<StringID>(mouthOpening, name: "mouthOpening");
			mouthOpeningEnd = s.SerializeObject<StringID>(mouthOpeningEnd, name: "mouthOpeningEnd");
			mouthBump = s.SerializeObject<StringID>(mouthBump, name: "mouthBump");
			mouthHit = s.SerializeObject<StringID>(mouthHit, name: "mouthHit");
			platformPolylineParameterIndex = s.Serialize<uint>(platformPolylineParameterIndex, name: "platformPolylineParameterIndex");
			spikesPolylineParameterIndex = s.Serialize<uint>(spikesPolylineParameterIndex, name: "spikesPolylineParameterIndex");
		}
		public override uint? ClassCRC => 0x4EEC810A;
	}
}

