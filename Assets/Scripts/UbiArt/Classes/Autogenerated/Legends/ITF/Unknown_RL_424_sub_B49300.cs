using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_424_sub_B49300 : CSerializable {
		[Serialize("TrailTemplate"     )] public Placeholder TrailTemplate;
		[Serialize("BulletPath"        )] public Path BulletPath;
		[Serialize("BasePath"          )] public Path BasePath;
		[Serialize("BackgroundDistance")] public float BackgroundDistance;
		[Serialize("BorderThreeshold"  )] public float BorderThreeshold;
		[Serialize("murphyOffset"      )] public Vector3 murphyOffset;
		[Serialize("SlingShotBase"     )] public Vector3 SlingShotBase;
		[Serialize("SpringDepthOffset" )] public float SpringDepthOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(TrailTemplate));
			SerializeField(s, nameof(BulletPath));
			SerializeField(s, nameof(BasePath));
			SerializeField(s, nameof(BackgroundDistance));
			SerializeField(s, nameof(BorderThreeshold));
			SerializeField(s, nameof(murphyOffset));
			SerializeField(s, nameof(SlingShotBase));
			SerializeField(s, nameof(SpringDepthOffset));
		}
		public override uint? ClassCRC => 0x87BB8F23;
	}
}

