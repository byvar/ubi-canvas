using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_MineComponent : ActorComponent {
		public int UseTween;
		public float HorizontalAmplitude;
		public float HorizontalFreq;
		public float VerticalAmplitude;
		public float VerticalFreq;
		public float TwistAmplitude;
		public float RotationSpeed;
		public int Size;
		public bool UseSoftCol;
		public float SoftColDist;
		public float SoftColDistStop;
		public float SoftColStrengthReturn;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			UseTween = s.Serialize<int>(UseTween, name: "UseTween");
			HorizontalAmplitude = s.Serialize<float>(HorizontalAmplitude, name: "HorizontalAmplitude");
			HorizontalFreq = s.Serialize<float>(HorizontalFreq, name: "HorizontalFreq");
			VerticalAmplitude = s.Serialize<float>(VerticalAmplitude, name: "VerticalAmplitude");
			VerticalFreq = s.Serialize<float>(VerticalFreq, name: "VerticalFreq");
			TwistAmplitude = s.Serialize<float>(TwistAmplitude, name: "TwistAmplitude");
			RotationSpeed = s.Serialize<float>(RotationSpeed, name: "RotationSpeed");
			Size = s.Serialize<int>(Size, name: "Size");
			UseSoftCol = s.Serialize<bool>(UseSoftCol, name: "UseSoftCol");
			if (UseSoftCol) {
				SoftColDist = s.Serialize<float>(SoftColDist, name: "SoftColDist");
				SoftColDistStop = s.Serialize<float>(SoftColDistStop, name: "SoftColDistStop");
				SoftColStrengthReturn = s.Serialize<float>(SoftColStrengthReturn, name: "SoftColStrengthReturn");
			}
		}
		public override uint? ClassCRC => 0x15DA355C;
	}
}

