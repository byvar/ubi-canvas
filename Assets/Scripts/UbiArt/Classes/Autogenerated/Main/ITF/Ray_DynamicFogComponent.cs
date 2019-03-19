using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_DynamicFogComponent : ActorComponent {
		[Serialize("useTempateFogParams")] public int useTempateFogParams;
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
		public override uint? ClassCRC => 0x3104D334;
	}
}

