using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_CarnivorousPlatformComponent_Template : RO2_PlatformAIComponent_Template {
		[Serialize("closedDuration"                )] public float closedDuration;
		[Serialize("hitLevel"                      )] public uint hitLevel;
		[Serialize("mouthOpened"                   )] public StringID mouthOpened;
		[Serialize("mouthClosed"                   )] public StringID mouthClosed;
		[Serialize("mouthClosingStart"             )] public StringID mouthClosingStart;
		[Serialize("mouthClosing"                  )] public StringID mouthClosing;
		[Serialize("mouthOpening"                  )] public StringID mouthOpening;
		[Serialize("mouthOpeningEnd"               )] public StringID mouthOpeningEnd;
		[Serialize("mouthBump"                     )] public StringID mouthBump;
		[Serialize("mouthHit"                      )] public StringID mouthHit;
		[Serialize("platformPolylineParameterIndex")] public uint platformPolylineParameterIndex;
		[Serialize("spikesPolylineParameterIndex"  )] public uint spikesPolylineParameterIndex;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(closedDuration));
			SerializeField(s, nameof(hitLevel));
			SerializeField(s, nameof(mouthOpened));
			SerializeField(s, nameof(mouthClosed));
			SerializeField(s, nameof(mouthClosingStart));
			SerializeField(s, nameof(mouthClosing));
			SerializeField(s, nameof(mouthOpening));
			SerializeField(s, nameof(mouthOpeningEnd));
			SerializeField(s, nameof(mouthBump));
			SerializeField(s, nameof(mouthHit));
			SerializeField(s, nameof(platformPolylineParameterIndex));
			SerializeField(s, nameof(spikesPolylineParameterIndex));
		}
		public override uint? ClassCRC => 0x4EEC810A;
	}
}

