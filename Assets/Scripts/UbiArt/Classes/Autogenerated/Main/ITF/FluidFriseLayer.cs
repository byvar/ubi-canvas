using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RJR | GameFlags.RFR | GameFlags.RL | GameFlags.COL)]
	public partial class FluidFriseLayer : CSerializable {
		[Serialize("erosion"                      )] public uint erosion;
		[Serialize("color"                        )] public Color color;
		[Serialize("threshold"                    )] public float threshold;
		[Serialize("gameMaterial"                 )] public Path gameMaterial;
		[Serialize("backsideGameMaterial"         )] public Path backsideGameMaterial;
		[Serialize("collisionHeight"              )] public float collisionHeight;
		[Serialize("hasBacksideInversion"         )] public bool hasBacksideInversion;
		[Serialize("forcedHeightWhenNotColored"   )] public float forcedHeightWhenNotColored;
		[Serialize("hasForcedHeightWhenNotColored")] public bool hasForcedHeightWhenNotColored;
		[Serialize("float__0"                     )] public float float__0;
		[Serialize("Color__1"                     )] public Color Color__1;
		[Serialize("Path__2"                      )] public Path Path__2;
		[Serialize("Path__3"                      )] public Path Path__3;
		[Serialize("float__4"                     )] public float float__4;
		[Serialize("int__5"                       )] public int int__5;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR) {
				SerializeField(s, nameof(float__0));
				SerializeField(s, nameof(Color__1));
				SerializeField(s, nameof(Path__2));
				SerializeField(s, nameof(Path__3));
				SerializeField(s, nameof(float__4));
				SerializeField(s, nameof(int__5));
			} else {
				SerializeField(s, nameof(erosion));
				SerializeField(s, nameof(color));
				SerializeField(s, nameof(threshold));
				SerializeField(s, nameof(gameMaterial));
				SerializeField(s, nameof(backsideGameMaterial));
				SerializeField(s, nameof(collisionHeight));
				SerializeField(s, nameof(hasBacksideInversion));
				SerializeField(s, nameof(forcedHeightWhenNotColored));
				SerializeField(s, nameof(hasForcedHeightWhenNotColored));
			}
		}
	}
}

