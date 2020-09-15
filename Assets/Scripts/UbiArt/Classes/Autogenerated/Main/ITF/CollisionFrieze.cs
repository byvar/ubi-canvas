using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class CollisionFrieze : CSerializable {
		[Serialize("build"                    )] public bool build;
		[Serialize("offset"                   )] public float offset;
		[Serialize("extremity"                )] public Vec2d extremity;
		[Serialize("extremity2"               )] public Vec2d extremity2;
		[Serialize("flip"                     )] public bool flip;
		[Serialize("methode"                  )] public uint methode;
		[Serialize("distMaxToSkipParallelEdge")] public float distMaxToSkipParallelEdge;
		[Serialize("smoothFactor"             )] public float smoothFactor;
		[Serialize("isSmooth"                 )] public bool isSmooth;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(build));
				SerializeField(s, nameof(offset));
				SerializeField(s, nameof(extremity));
				SerializeField(s, nameof(extremity2));
				SerializeField(s, nameof(flip), boolAsByte: true);
				SerializeField(s, nameof(methode));
				SerializeField(s, nameof(distMaxToSkipParallelEdge));
				SerializeField(s, nameof(smoothFactor));
				if (s.HasFlags(SerializeFlags.Flags10)) {
					SerializeField(s, nameof(isSmooth), boolAsByte: true);
				}
			} else {
				SerializeField(s, nameof(build));
				SerializeField(s, nameof(offset));
				SerializeField(s, nameof(extremity));
				SerializeField(s, nameof(extremity2));
				SerializeField(s, nameof(flip));
				SerializeField(s, nameof(methode));
				SerializeField(s, nameof(distMaxToSkipParallelEdge));
				SerializeField(s, nameof(smoothFactor));
				if (s.HasFlags(SerializeFlags.Flags10)) {
					SerializeField(s, nameof(isSmooth));
				}
			}
		}
	}
}

