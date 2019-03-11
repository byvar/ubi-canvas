using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_ExtraLumsComponent_Template : ActorComponent_Template {
		[Serialize("lumsCount"            )] public uint lumsCount;
		[Serialize("disappearStartTime"   )] public float disappearStartTime;
		[Serialize("disappearIntervalTime")] public float disappearIntervalTime;
		[Serialize("lumsDistance"         )] public float lumsDistance;
		[Serialize("lumsScale"            )] public float lumsScale;
		[Serialize("lumsRotationSpeed"    )] public Angle lumsRotationSpeed;
		[Serialize("attachedBone"         )] public StringID attachedBone;
		[Serialize("lumsAnimAppear"       )] public StringID lumsAnimAppear;
		[Serialize("lumsAnimStand"        )] public StringID lumsAnimStand;
		[Serialize("lumsAnimDisappear"    )] public StringID lumsAnimDisappear;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(lumsCount));
			SerializeField(s, nameof(disappearStartTime));
			SerializeField(s, nameof(disappearIntervalTime));
			SerializeField(s, nameof(lumsDistance));
			SerializeField(s, nameof(lumsScale));
			SerializeField(s, nameof(lumsRotationSpeed));
			SerializeField(s, nameof(attachedBone));
			SerializeField(s, nameof(lumsAnimAppear));
			SerializeField(s, nameof(lumsAnimStand));
			SerializeField(s, nameof(lumsAnimDisappear));
		}
		public override uint? ClassCRC => 0x46EA8D63;
	}
}

