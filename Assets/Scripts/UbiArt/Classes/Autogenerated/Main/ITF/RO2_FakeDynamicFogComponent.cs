using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_FakeDynamicFogComponent : ActorComponent {
		[Serialize("hasMesh3D"                )] public bool hasMesh3D;
		[Serialize("iActivatedInit"           )] public bool iActivatedInit;
		[Serialize("DistanceLocalToSceneDepth")] public bool DistanceLocalToSceneDepth;
		[Serialize("foreGroundColor"          )] public Color foreGroundColor;
		[Serialize("foreGroundColor_ZStart"   )] public float foreGroundColor_ZStart;
		[Serialize("foreGroundColor_ZEnd"     )] public float foreGroundColor_ZEnd;
		[Serialize("fogColor"                 )] public Color fogColor;
		[Serialize("fogZStart"                )] public float fogZStart;
		[Serialize("fogZEnd"                  )] public float fogZEnd;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(hasMesh3D));
			SerializeField(s, nameof(iActivatedInit));
			SerializeField(s, nameof(DistanceLocalToSceneDepth));
			SerializeField(s, nameof(foreGroundColor));
			SerializeField(s, nameof(foreGroundColor_ZStart));
			SerializeField(s, nameof(foreGroundColor_ZEnd));
			SerializeField(s, nameof(fogColor));
			SerializeField(s, nameof(fogZStart));
			SerializeField(s, nameof(fogZEnd));
		}
		public override uint? ClassCRC => 0x5BA9FA05;
	}
}

