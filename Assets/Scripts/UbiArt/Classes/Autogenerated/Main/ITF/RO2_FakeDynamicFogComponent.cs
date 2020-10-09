using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_FakeDynamicFogComponent : ActorComponent {
		public bool hasMesh3D;
		public bool iActivatedInit;
		public bool DistanceLocalToSceneDepth;
		public Color foreGroundColor;
		public float foreGroundColor_ZStart;
		public float foreGroundColor_ZEnd;
		public Color fogColor;
		public float fogZStart;
		public float fogZEnd;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			hasMesh3D = s.Serialize<bool>(hasMesh3D, name: "hasMesh3D");
			iActivatedInit = s.Serialize<bool>(iActivatedInit, name: "iActivatedInit");
			DistanceLocalToSceneDepth = s.Serialize<bool>(DistanceLocalToSceneDepth, name: "DistanceLocalToSceneDepth");
			foreGroundColor = s.SerializeObject<Color>(foreGroundColor, name: "foreGroundColor");
			foreGroundColor_ZStart = s.Serialize<float>(foreGroundColor_ZStart, name: "foreGroundColor_ZStart");
			foreGroundColor_ZEnd = s.Serialize<float>(foreGroundColor_ZEnd, name: "foreGroundColor_ZEnd");
			fogColor = s.SerializeObject<Color>(fogColor, name: "fogColor");
			fogZStart = s.Serialize<float>(fogZStart, name: "fogZStart");
			fogZEnd = s.Serialize<float>(fogZEnd, name: "fogZEnd");
		}
		public override uint? ClassCRC => 0x5BA9FA05;
	}
}

