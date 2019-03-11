using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_DarkRaymanComponent_Template : ActorComponent_Template {
		[Serialize("frameToWaitBeforeRehit"         )] public uint frameToWaitBeforeRehit;
		[Serialize("waitDurationWhenDead"           )] public float waitDurationWhenDead;
		[Serialize("nextInfectionTransitionDuration")] public float nextInfectionTransitionDuration;
		[Serialize("travelAccelType"                )] public uint travelAccelType;
		[Serialize("FXDarkRayman"                   )] public StringID FXDarkRayman;
		[Serialize("FXGhostedPlayer"                )] public StringID FXGhostedPlayer;
		[Serialize("FXVortex"                       )] public StringID FXVortex;
		[Serialize("FXOnHit"                        )] public StringID FXOnHit;
		[Serialize("FXAppear"                       )] public StringID FXAppear;
		[Serialize("FXDisappear"                    )] public StringID FXDisappear;
		[Serialize("FXDisappearAndInfect"           )] public StringID FXDisappearAndInfect;
		[Serialize("FXMock"                         )] public StringID FXMock;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(frameToWaitBeforeRehit));
			SerializeField(s, nameof(waitDurationWhenDead));
			SerializeField(s, nameof(nextInfectionTransitionDuration));
			SerializeField(s, nameof(travelAccelType));
			SerializeField(s, nameof(FXDarkRayman));
			SerializeField(s, nameof(FXGhostedPlayer));
			SerializeField(s, nameof(FXVortex));
			SerializeField(s, nameof(FXOnHit));
			SerializeField(s, nameof(FXAppear));
			SerializeField(s, nameof(FXDisappear));
			SerializeField(s, nameof(FXDisappearAndInfect));
			SerializeField(s, nameof(FXMock));
		}
		public override uint? ClassCRC => 0x1DFBB1D1;
	}
}

