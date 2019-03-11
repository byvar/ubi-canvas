using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_ShooterPirateShipAIComponent : Ray_BigMamaAIComponent {
		[Serialize("useTempateFogParams")] public bool useTempateFogParams;
		[Serialize("dynamicFogColor"    )] public Color dynamicFogColor;
		[Serialize("dynamicFogMaxDepth" )] public float dynamicFogMaxDepth;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(useTempateFogParams));
				SerializeField(s, nameof(dynamicFogColor));
				SerializeField(s, nameof(dynamicFogMaxDepth));
			}
		}
		public override uint? ClassCRC => 0x4FDAE284;
	}
}

