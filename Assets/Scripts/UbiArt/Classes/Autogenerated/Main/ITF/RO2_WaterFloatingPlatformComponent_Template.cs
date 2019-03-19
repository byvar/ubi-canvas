using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_WaterFloatingPlatformComponent_Template : ActorComponent_Template {
		[Serialize("stiff"           )] public float stiff;
		[Serialize("damp"            )] public float damp;
		[Serialize("weightToAngle"   )] public float weightToAngle;
		[Serialize("weightToHeight"  )] public float weightToHeight;
		[Serialize("maxAngle"        )] public Angle maxAngle;
		[Serialize("maxHeight"       )] public float maxHeight;
		[Serialize("weightMultiplier")] public float weightMultiplier;
		[Serialize("forceMultiplier" )] public float forceMultiplier;
		[Serialize("floatMinHeight"  )] public float floatMinHeight;
		[Serialize("floatMaxHeight"  )] public float floatMaxHeight;
		[Serialize("floatMinAngle"   )] public Angle floatMinAngle;
		[Serialize("floatMaxAngle"   )] public Angle floatMaxAngle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(stiff));
			SerializeField(s, nameof(damp));
			SerializeField(s, nameof(weightToAngle));
			SerializeField(s, nameof(weightToHeight));
			SerializeField(s, nameof(maxAngle));
			SerializeField(s, nameof(maxHeight));
			SerializeField(s, nameof(weightMultiplier));
			SerializeField(s, nameof(forceMultiplier));
			SerializeField(s, nameof(floatMinHeight));
			SerializeField(s, nameof(floatMaxHeight));
			SerializeField(s, nameof(floatMinAngle));
			SerializeField(s, nameof(floatMaxAngle));
		}
		public override uint? ClassCRC => 0xD79CDCBB;
	}
}

