using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_MineComponent : ActorComponent {
		[Serialize("UseTween"             )] public int UseTween;
		[Serialize("HorizontalAmplitude"  )] public float HorizontalAmplitude;
		[Serialize("HorizontalFreq"       )] public float HorizontalFreq;
		[Serialize("VerticalAmplitude"    )] public float VerticalAmplitude;
		[Serialize("VerticalFreq"         )] public float VerticalFreq;
		[Serialize("TwistAmplitude"       )] public float TwistAmplitude;
		[Serialize("RotationSpeed"        )] public float RotationSpeed;
		[Serialize("Size"                 )] public int Size;
		[Serialize("UseSoftCol"           )] public bool UseSoftCol;
		[Serialize("SoftColDist"          )] public float SoftColDist;
		[Serialize("SoftColDistStop"      )] public float SoftColDistStop;
		[Serialize("SoftColStrengthReturn")] public float SoftColStrengthReturn;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(UseTween));
			SerializeField(s, nameof(HorizontalAmplitude));
			SerializeField(s, nameof(HorizontalFreq));
			SerializeField(s, nameof(VerticalAmplitude));
			SerializeField(s, nameof(VerticalFreq));
			SerializeField(s, nameof(TwistAmplitude));
			SerializeField(s, nameof(RotationSpeed));
			SerializeField(s, nameof(Size));
			SerializeField(s, nameof(UseSoftCol));
			if (UseSoftCol) {
				SerializeField(s, nameof(SoftColDist));
				SerializeField(s, nameof(SoftColDistStop));
				SerializeField(s, nameof(SoftColStrengthReturn));
			}
		}
		public override uint? ClassCRC => 0x15DA355C;
	}
}

