using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_FluidSimulationComponent_Template : RO2_SoftCollisionComponent_Template {
		[Serialize("FX"           )] public StringID FX;
		[Serialize("SpawnSound"   )] public StringID SpawnSound;
		[Serialize("SwarmSound"   )] public StringID SwarmSound;
		[Serialize("CaughtSound"  )] public StringID CaughtSound;
		[Serialize("ReleaseSound" )] public StringID ReleaseSound;
		[Serialize("InputMaxSpeed")] public float InputMaxSpeed;
		[Serialize("RadiusMin"    )] public float RadiusMin;
		[Serialize("RadiusMax"    )] public float RadiusMax;
		[Serialize("DrawObstacles")] public bool DrawObstacles;
		[Serialize("DrawPlayers"  )] public bool DrawPlayers;
		[Serialize("DrawCircles"  )] public bool DrawCircles;
		[Serialize("FluidMaterial")] public GFXMaterialSerializable FluidMaterial;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(FX));
			SerializeField(s, nameof(SpawnSound));
			SerializeField(s, nameof(SwarmSound));
			SerializeField(s, nameof(CaughtSound));
			SerializeField(s, nameof(ReleaseSound));
			SerializeField(s, nameof(InputMaxSpeed));
			SerializeField(s, nameof(RadiusMin));
			SerializeField(s, nameof(RadiusMax));
			SerializeField(s, nameof(DrawObstacles));
			SerializeField(s, nameof(DrawPlayers));
			SerializeField(s, nameof(DrawCircles));
			SerializeField(s, nameof(FluidMaterial));
		}
		public override uint? ClassCRC => 0x6F917056;
	}
}

