using UnityEngine;

namespace UbiArt.ITF {
	public partial class BaseCameraComponent_Template : ActorComponent_Template {
		[Serialize("startAsMainCam")] public bool startAsMainCam;
		[Serialize("rampUpCoeff"   )] public float rampUpCoeff;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(startAsMainCam));
			SerializeField(s, nameof(rampUpCoeff));
		}
		public override uint? ClassCRC => 0x680B2173;
	}
}

