using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RJR | GameFlags.RFR)]
	public partial class FriezeConnectionResult : CSerializable {
		[Serialize("pos"          )] public Vec2d pos;
		[Serialize("prevOwner"    )] public ObjectPath prevOwner;
		[Serialize("prevColId"    )] public uint prevColId;
		[Serialize("nextOwner"    )] public ObjectPath nextOwner;
		[Serialize("nextColId"    )] public uint nextColId;
		[Serialize("Vector2__0"   )] public Vec2d Vector2__0;
		[Serialize("ObjectPath__1")] public ObjectPath ObjectPath__1;
		[Serialize("uint__2"      )] public uint uint__2;
		[Serialize("ObjectPath__3")] public ObjectPath ObjectPath__3;
		[Serialize("uint__4"      )] public uint uint__4;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR) {
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(Vector2__0));
					SerializeField(s, nameof(ObjectPath__1));
					SerializeField(s, nameof(uint__2));
					SerializeField(s, nameof(ObjectPath__3));
					SerializeField(s, nameof(uint__4));
				}
			} else {
				SerializeField(s, nameof(pos));
				SerializeField(s, nameof(prevOwner));
				SerializeField(s, nameof(prevColId));
				SerializeField(s, nameof(nextOwner));
				SerializeField(s, nameof(nextColId));
			}
		}
	}
}

